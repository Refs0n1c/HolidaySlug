using System;

namespace HolidaySlug.API.DomainModels
{
    public class HolidayModel
    {

        public Guid ID { get; set; }
        public string HolidayReason { get; set; }
        public HolidayTypeModel HolidayType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DaysUsed { get; set; }
        
        public UserModel User { get; set; }
        public bool Approved { get; set; }
        public UserModel ApprovedByUser { get; set; }

    }
}