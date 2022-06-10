using App.DataProvider;
using App.Services.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.RepositoryPattern
{
    public class VehicleService : IVehicleService
    {
        private readonly ParkingBoundedContext _parkingDBContext;
        private readonly IMapper _mapper;

        public VehicleService(ParkingBoundedContext ParkingDBContext, IMapper mapper)
        {
            _parkingDBContext = ParkingDBContext;
            _mapper = mapper;

        }

        public async Task<List<VehicleDto>> GetVehicles()
        {
            try
            {
                var db = await _parkingDBContext.Vehicles.ToListAsync();


                return _mapper.Map<List<VehicleDto>>(db);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<VehicleDto> GetOne(int id)
        {
            try
            {
                var db = _parkingDBContext.Vehicles.Where(x => x.Type == id).SingleOrDefault();

                var temp = _mapper.Map<VehicleDto>(db);
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
