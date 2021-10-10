using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Business.ViewModels
{
    public class ActionTrackerViewModel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string Matchine { get; set; }
        public string Browser { get; set; }
        public string IP { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}