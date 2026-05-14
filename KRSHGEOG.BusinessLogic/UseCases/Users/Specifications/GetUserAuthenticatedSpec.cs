using Ardalis.Specification;
using KRSHGEOG.Entities;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Specifications
{
    public class GetUserAuthenticatedSpec : Specification<User>
    {
        public GetUserAuthenticatedSpec(string Username, string Password)
        {
            Query.Where(u =>
                u.Username == Username &&
                u.PasswordHash == Password
            );

            Query.Include(u => u.Role);
        }
    }
}
