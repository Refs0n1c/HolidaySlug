using System;

namespace HolidaySlug.Services.DTO
{
    public class UserTeamDTO
    {
        public Guid Id { get; set; }
        public UserDTO User { get; set; }
        public UserDTO Manager { get; set; }

    }
}