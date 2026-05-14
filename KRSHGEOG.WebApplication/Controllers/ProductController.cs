using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.BusinessLogic.UseCases.Brands.Queries.GetBrands;
using KRSHGEOG.BusinessLogic.UseCases.Products.Commands.CreateProduct;
using KRSHGEOG.BusinessLogic.UseCases.Products.Commands.UpdateProduct;
using KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProduct;
using KRSHGEOG.BusinessLogic.UseCases.Products.Queries.GetProducts;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KRSHGEOG.WebApplication.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            _mediator = mediator;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: ProductController
        public async Task<IActionResult> Index()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return View(products);
        }

        // GET: BrandController/Create
        public async Task<IActionResult> Create()
        {
            var brands = await _mediator.Send(new GetBrandsQuery());
            ViewBag.ToolBrandId = new SelectList(brands, "Id", "BrandName");
            return View();
        }
        public async Task<string> SaveImage(IFormFile? file, string url = "")
        {
            string urlImage = url;
            if (file != null && file.Length > 0)
            {
                string nameFile = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "images", nameFile);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                urlImage = "/images/" + nameFile;
            }
            return urlImage;
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SolicitudCrearProducto createProductRequest, IFormFile? file = null)
        {
            try
            {
                var result = await _mediator.Send(new CreateProductCommand(createProductRequest));
                if (result > 0)
                    return RedirectToAction(nameof(Index));
                else
                    throw new Exception("Sucedio un error la intentar guardar la nuevo producto");
            }
            catch (Exception ex)
            {
                var brands = await _mediator.Send(new GetBrandsQuery());
                ViewBag.ToolBrandId = new SelectList(brands, "Id", "BrandName", createProductRequest.ToolBrandId);
                ModelState.AddModelError("", ex.InnerException?.Message ?? ex.Message);
                return View(createProductRequest);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _mediator.Send(new GetProductQuery(id));
            var brands = await _mediator.Send(new GetBrandsQuery());
            ViewBag.ToolBrandId = new SelectList(brands, "Id", "BrandName", product.ToolBrandId);
            return View(product.Adapt(new SolicitudActualizarProducto()));
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SolicitudActualizarProducto updateProductRequest, IFormFile? file = null)
        {
            try
            {
                var result = await _mediator.Send(new UpdateProductCommand(updateProductRequest));
                if (result > 0)
                    return RedirectToAction(nameof(Index));
                else
                    throw new Exception("Sucedio un error la intentar editar producto");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException?.Message ?? ex.Message);
                var brands = await _mediator.Send(new GetBrandsQuery());
                ViewBag.ToolBrandId = new SelectList(brands, "Id", "BrandName", updateProductRequest.ToolBrandId);
                return View(updateProductRequest);
            }
        }
    }
}
