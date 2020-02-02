using System;

namespace HolidaySlug.API.DomainModels
{
    public class HolidayHistoryModel
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }

        public UserModel User { get; set; }
        public HolidayModel Holiday { get; set; }
    }
}