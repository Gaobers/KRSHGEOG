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

            config.NewConfig<User, UserResponse>()
                .Map(ud => ud.RoleId, u => u.Role.Name);
        }
    }
}
