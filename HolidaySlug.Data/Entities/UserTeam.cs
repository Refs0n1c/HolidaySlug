using System;
using System.Collections.Generic;

namespace HolidaySlug.Data.Entities
{
    public class UserTeam
    {
        public Guid ID { get; set; }
        public List<User> Users { get; set; }
        public User Manager { get; set; }
        
    }
}