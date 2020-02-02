using System;
using System.Collections.Generic;
using HolidaySlug.Services.DTO;
using HolidaySlug.Services.Interfaces;

namespace HolidaySlug.Services.Implementations
{
    public class HolidayService : IHolidayService
    {
        public IEnumerable<HolidayDTO> GetHolidaysByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public HolidayDTO FindHoliday(Guid holidayId)
        {
            throw new NotImplementedException();
        }

        public void CreateHoliday(HolidayDTO holiday)
        {
            throw new NotImplementedException();
        }

        public void UpdateHoliday(HolidayDTO holiday)
        {
            throw new NotImplementedException();
        }

        public void DeleteHoliday(Guid holiodayId)
        {
            throw new NotImplementedException();
        }
    }
}