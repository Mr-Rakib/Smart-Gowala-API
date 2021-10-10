using SmartGowala.Data.Data.Context;
using SmartGowala.Data.Data.Models;
using SmartGowala.Shared.Infrustructure;
using SmartGowala.Shared.Infrustructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Data.Data.Repositories
{
    public interface IActionTrackerRepository : IRepository<ActionTracker>
    {
    }
    public class ActionTrackerRepository : Repository<ActionTracker>, IActionTrackerRepository
    {
        private SmartGowalaDBContext _smartGowalaDBContext;
        public ActionTrackerRepository(SmartGowalaDBContext smartGowalaDBContext) : base(smartGowalaDBContext)
        {
            _smartGowalaDBContext = smartGowalaDBContext;
        }
    }
}
