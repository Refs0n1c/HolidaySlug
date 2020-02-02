using System;
using System.Collections.Generic;

namespace HolidaySlug.Services.DTO
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int Entitlement { get; set; }
        public bool IsManager { get; set; }
        public ICollection<HolidayDTO> Holidays { get; set; }
        public UserTeamDTO UserTeam { get; set; }
    }
}