using System;
using System.ComponentModel.DataAnnotations;

namespace HolidaySlug.Data.Entities
{
    public class HolidayHistory
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }

        [Required] public User User { get; set; }
        [Required] public Holiday Holiday { get; set; }
    }
}