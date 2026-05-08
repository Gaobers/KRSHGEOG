using System;
using System.Collections.Generic;
using System.Text;

namespace KRSHGEOG.BusinessLogic.DTOs
{
    public class CreateBrandRequest

    {
        public string BrandName { get; set; } = null!;
        }
    public class UpdateBrandRequest
    {
        public int Id { get; set; }

        public string BrandName { get; set; } = null!;

       }
    public class BrandResponse
    {
        public int Id { get; set; }

        public string BrandName { get; set; } = null!;
        }
        
    }

