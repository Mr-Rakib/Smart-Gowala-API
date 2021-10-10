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
    public interface IActionTrackerService : IBaseService<ActionTrackerViewModel, ActionTracker> {
    
    }
    public class ActionTrackerService : BaseService<ActionTrackerViewModel, ActionTracker>, IActionTrackerService
    {
        private IActionTrackerRepository _actionTrackerRepository;
        public ActionTrackerService(IActionTrackerRepository actionTrackerRepository) : base(actionTrackerRepository)
        {
            _actionTrackerRepository = actionTrackerRepository;
        }
    }
}
