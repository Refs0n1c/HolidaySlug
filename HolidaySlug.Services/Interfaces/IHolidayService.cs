using System;
using System.Collections.Generic;
using HolidaySlug.Services.DTO;

namespace HolidaySlug.Services.Interfaces
{
    public interface IHolidayService
    {
        IEnumerable<HolidayDTO> GetHolidaysByUser(Guid userId);
        HolidayDTO FindHoliday(Guid holidayId);
        void CreateHoliday(HolidayDTO holiday);
        void UpdateHoliday(HolidayDTO holiday);
        void DeleteHoliday(Guid holiodayId);
    }
}