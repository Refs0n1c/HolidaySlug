using System;
using System.Collections.Generic;

namespace HolidaySlug.Data.Entities
{
    public class UserTeam
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public User Manager { get; set; }

    }
}