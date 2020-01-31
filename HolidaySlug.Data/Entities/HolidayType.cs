using System;
using System.ComponentModel.DataAnnotations;

namespace HolidaySlug.Data.Entities
{
    public class HolidayType
    {

        public Guid ID { get; set; }
        public string Type { get; set; }

    }
}