using System;
using System.Collections.Generic;
using HolidaySlug.Data.Entities;

namespace HolidaySlug.Data.Repositories.Interfaces
{
    public interface IHolidayRepository : IRepository<Holiday>
    {
        List<Holiday> GetHolidaysToApprove(Guid managerId);
        void ApproveHoliday(Holiday holiday,User manager);
    }
}