using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using AutoMapper;
using HolidaySlug.Data.Entities;
using HolidaySlug.Data.Repositories.Interfaces;
using HolidaySlug.Services.BusinessLogic;
using HolidaySlug.Services.DTO;
using HolidaySlug.Services.Interfaces;

namespace HolidaySlug.Services.Implementations
{
    public class HolidayService : IHolidayService
    {
        private IMapper _mapper;
        private IHolidayRepository _holidayRepo;

        public HolidayService(IMapper mapper,IHolidayRepository holidayRepo)
        {
            _mapper = mapper;
            _holidayRepo = holidayRepo;
        }
        public IEnumerable<HolidayDTO> GetHolidaysByUser(Guid userId)
        {
            var results = _holidayRepo.GetHolidays(userId);

            return _mapper.Map<List<HolidayDTO>>(results);
        }

        public HolidayDTO FindHoliday(Guid holidayId)
        {
            var results = _holidayRepo.GetById(holidayId);

            return _mapper.Map<HolidayDTO>(results);
        }

        public bool CreateHoliday(HolidayDTO holiday)
        {
            if (!HolidayBL.IsValid(holiday)) return false;
            _holidayRepo.AddHoliday(_mapper.Map<Holiday>(holiday));

            return true;

        }

        public bool UpdateHoliday(HolidayDTO holiday)
        {
            if (!HolidayBL.IsValid(holiday)) return false;
            _holidayRepo.Update(_mapper.Map<Holiday>(holiday));

            return true;
        }

        public bool DeleteHoliday(HolidayDTO holiday)
        {
            if (!HolidayBL.IsValid(holiday)) return false;
            _holidayRepo.DeleteHoliday(_mapper.Map<Holiday>(holiday));

            return true;
        }
    }
}