using AutoMapper;
using SmartGowala.Business.Business.ViewModels;
using SmartGowala.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Infrastructure.Mapping
{
    public class DatabaseToDomainProfile : Profile
    {
        public void Configure()
        {
            CreateMap<UserRole, UserRoleViewModel>();
            CreateMap<ActionTracker, ActionTrackerViewModel>();
        }
    }
}
