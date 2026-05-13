using KRSHGEOG.BusinessLogic.DTOs;
using KRSHGEOG.Entities;
using Mapster;

namespace KRSHGEOG.BusinessLogic.Mappings
{
    public class MappingRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<HardwareProduct, ProductoResponse>();
        }
    }
}
