using SmartGowala.Business.Business.ViewModels;
using SmartGowala.Data.Data.Models;
using SmartGowala.Data.Data.Repositories;
using SmartGowala.Shared.Infrustructure;
using SmartGowala.Shared.Infrustructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Business.Services
{
    public interface IUserRoleService : IBaseService<UserRoleViewModel, UserRole> { }
    public class UserRoleService : BaseService<UserRoleViewModel, UserRole>, IUserRoleService
    {
        private IUserRoleRepository _userRoleRepository;
        public UserRoleService (IUserRoleRepository userRoleRepository) : base(userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }
    }
}
