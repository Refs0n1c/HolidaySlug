using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolidaySlug.Data.Entities
{
    public class Holiday
    {
        
        public Guid ID { get; set; }
        public string HolidayReason { get; set; }
        public HolidayType HolidayType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DaysUsed { get; set; }
      
       
        public User User { get; set; }
        public bool Approved { get; set; }
        
        
        public User ApprovedByUser { get; set; }
        
    }
}