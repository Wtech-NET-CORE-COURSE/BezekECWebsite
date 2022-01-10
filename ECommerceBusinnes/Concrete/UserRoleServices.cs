using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class UserRoleServices : IUserRoleServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserRole> CreateRole(UserRole userRole)
        {
            await _unitOfWork.Roles.AddAsync(userRole);
            await _unitOfWork.CommitAsync();
            return userRole;
        }

        public Task DeleteUserRole(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserRole>> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> GetUserRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserRole(UserRole roleToBeUpdated, UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
