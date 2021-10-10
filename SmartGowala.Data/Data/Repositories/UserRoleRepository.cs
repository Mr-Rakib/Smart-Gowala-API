using SmartGowala.Data.Data.Context;
using SmartGowala.Data.Data.Models;
using SmartGowala.Shared.Infrustructure;
using SmartGowala.Shared.Infrustructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Data.Data.Repositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {

    }
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository (SmartGowalaDBContext smartGowalaDBContext): base(smartGowalaDBContext)
        {

        }
    }
}
