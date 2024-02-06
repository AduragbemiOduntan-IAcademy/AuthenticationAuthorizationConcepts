using AuthenticationAuthorizationConcepts.Common.Dtos;
using AuthenticationAuthorizationConcepts.Domain.Entities;

namespace AuthenticationAuthorizationConcepts.Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<User> Create(UserRequestDto userRequest);
        void Update(UserUpdateDto userRequest, int id);
        void Delete(int id);
        Task<User> GetUserById(int id);
        Task<IQueryable<User>> GetAllUser();
    }
}
