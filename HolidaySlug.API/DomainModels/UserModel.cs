using System;
using System.Collections.Generic;

namespace HolidaySlug.API.DomainModels
{
    public class UserModel
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int Entitlement { get; set; }
        public bool IsManager { get; set; }
        public ICollection<HolidayModel> Holidays { get; set; }
        public UserTeamModel UserTeam { get; set; }
    }
}