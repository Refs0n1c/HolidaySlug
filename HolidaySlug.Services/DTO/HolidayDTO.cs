using System;

namespace HolidaySlug.Services.DTO
{
    public class HolidayDTO
    {

        public Guid ID { get; set; }
        public string HolidayReason { get; set; }
        public HolidayTypeDTO HolidayType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DaysUsed { get; set; }
        
        public UserDTO User { get; set; }
        public bool Approved { get; set; }
        public UserDTO ApprovedByUser { get; set; }

    }
}