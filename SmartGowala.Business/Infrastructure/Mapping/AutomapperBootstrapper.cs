using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Infrastructure.Mapping
{
    public static class AutomapperBootstrapper
    {
        public static void Initialize()
        {
            new DatabaseToDomainProfile().Configure();
            new DomainToDatabaseProfile().Configure();
        }
    }
}
