using ECommerceEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface IUserRoleServices
    {
        Task<IEnumerable<UserRole>> GetAllRoles();
        Task<UserRole> GetUserRoleById(int id);
        Task<UserRole> CreateRole(UserRole userRole);
        Task UpdateUserRole(UserRole roleToBeUpdated, UserRole userRole);
        Task DeleteUserRole(UserRole userRole);
    }
}
