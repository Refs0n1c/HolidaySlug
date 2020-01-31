using System;
using System.Collections.Generic;

namespace HolidaySlug.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int Entitlement { get; set; }
        public bool IsManager { get; set; }
        public ICollection<Holiday> Holidays { get; set; }
        public UserTeam UserTeam { get; set; }
    }
}