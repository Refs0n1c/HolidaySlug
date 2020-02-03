using System;
using System.Collections.Generic;
using HolidaySlug.Services.DTO;

namespace HolidaySlug.Services.Interfaces
{
    public interface IHolidayService
    {
        IEnumerable<HolidayDTO> GetHolidaysByUser(Guid userId);
        HolidayDTO FindHoliday(Guid holidayId);
        bool CreateHoliday(HolidayDTO holiday);
        bool UpdateHoliday(HolidayDTO holiday);
        bool DeleteHoliday(HolidayDTO holiday);
    }
}