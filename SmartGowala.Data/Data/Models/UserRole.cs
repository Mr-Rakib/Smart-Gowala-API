using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Data.Data.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
