using System;
using System.Collections.Generic;
using System.Linq;
using HolidaySlug.Data.Context;
using HolidaySlug.Data.Entities;
using HolidaySlug.Data.Repositories.Interfaces;

namespace HolidaySlug.Data.Repositories.Implementations
{
    public class HolidayRepository :BaseRepository<Holiday> ,IHolidayRepository
    {
        public HolidayRepository(HolidaySlugContext context) : base(context)
        {
        }
      

        public List<Holiday> GetHolidaysToApprove(Guid managerId)
        {
            return _table.Where(h => !h.Approved && h.User.UserTeam.Manager.ID == managerId).ToList();
        }

        public void ApproveHoliday(Holiday holiday, User manager)
        {
            holiday.Approved = true;
            holiday.ApprovedByUser = manager;
            _table.Update(holiday);
        }
    }
}