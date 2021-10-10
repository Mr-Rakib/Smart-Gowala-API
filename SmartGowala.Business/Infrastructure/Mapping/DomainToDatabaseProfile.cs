using AutoMapper;
using SmartGowala.Business.Business.ViewModels;
using SmartGowala.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Infrastructure.Mapping
{
    public class DomainToDatabaseProfile : Profile
    {
        public void Configure()
        {
            CreateMap<UserRoleViewModel, UserRole>();
            CreateMap<ActionTrackerViewModel, ActionTracker>();
        }

    }
}
