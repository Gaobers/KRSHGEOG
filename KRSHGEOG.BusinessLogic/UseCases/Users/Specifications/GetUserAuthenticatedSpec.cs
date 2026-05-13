using Ardalis.Specification;
using KRSHGEOG.Entities;

namespace KRSHGEOG.BusinessLogic.UseCases.Users.Specifications
{
    public class GetUserAuthenticatedSpec : Specification<User>
    {
        public GetUserAuthenticatedSpec(string Username, string PasswordHash)
        {
            Query.Where(u =>
            u.Username == Username
            && u.PasswordHash == PasswordHash
            );

            Query.Include(u => u.Role);
        }
    }
}
