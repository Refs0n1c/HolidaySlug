using System;

namespace HolidaySlug.Services.DTO
{
    public class HolidayHistoryDto
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }

        public UserDTO User { get; set; }
        public HolidayDTO Holiday { get; set; }
    }
}