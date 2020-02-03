using System;
using HolidaySlug.Services.DTO;

namespace HolidaySlug.Services.BusinessLogic
{
    public static class HolidayBL
    {
        
        public static bool IsValid(HolidayDTO holiday)
        {
            if (holiday.From < DateTime.Now || holiday.To < DateTime.Now)
            {
                return false;
            }

            if (holiday.HolidayType.Type == "HalfDay" && holiday.From.Date == DateTime.Today)
            {
                return false;
            }

            return true;
        }
    }
}