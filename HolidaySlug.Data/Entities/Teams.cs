using System;
using System.ComponentModel.DataAnnotations;

namespace HolidaySlug.Data.Entities
{
    public class Teams
    {
       
        public Guid ID { get; set; }
        public string TeamName { get; set; }
    }
}