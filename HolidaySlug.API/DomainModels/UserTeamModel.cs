using System;

namespace HolidaySlug.API.DomainModels
{
    public class UserTeamModel
    {
        public Guid Id { get; set; }
        public UserModel User { get; set; }
        public UserModel Manager { get; set; }

    }
}