using App.DataProvider;
using App.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Services.RepositoryPattern
{
    public class ParkingService : IParkingService
    {
        private readonly ParkingBoundedContext _parkingDBContext;
        private readonly IMapper _mapper;


        public ParkingService(ParkingBoundedContext ParkingDBContext, IMapper mapper)
        {
            _parkingDBContext = ParkingDBContext;
            _mapper = mapper;

        }

        public async Task<bool> Assign(string license, int level, int cardNo)
        {
            try
            {
                var vehicle = _parkingDBContext.Vehicles
                                           .Where(x => x.LicenseNo == license);

                if (vehicle.Any())
                {
                    Parking parking = new Parking
                    {
                        CardNo = cardNo,
                        LevelId = level,
                        VehicleId = vehicle.SingleOrDefault().Id,
                        FromDate = DateTime.Now,
                        EndDate = null
                    };

                    await _parkingDBContext.Parkings.AddAsync(parking);

                    await _parkingDBContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    Vehicle vehicleData = new Vehicle
                    {
                        LicenseNo = license
                    };

                    var result = await _parkingDBContext.Vehicles.AddAsync(vehicleData);

                    await _parkingDBContext.SaveChangesAsync();

                    Parking parking = new Parking
                    {
                        CardNo = cardNo,
                        LevelId = level,
                        VehicleId = result.Entity.Id,
                        FromDate = DateTime.Now,
                        EndDate = null
                    };

                    await _parkingDBContext.Parkings.AddAsync(parking);

                    await _parkingDBContext.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public int NumberOfLot(int level)
        {
            try
            {
                var numberOfFreeLot = _parkingDBContext.Capacities
                                            .Where(x => x.Level.Id == level).SingleOrDefault().Amount;

                var parkingLots = _parkingDBContext.Parkings
                                           .Where(x => x.LevelId == level).Sum(x => x.Id);

                numberOfFreeLot = numberOfFreeLot - parkingLots;

                return numberOfFreeLot;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ReAssign(string license, int level, int cardNo)
        {
            try
            {
                var dataExists = _parkingDBContext.Parkings.Where(c => c.CardNo.Equals(cardNo)).SingleOrDefault();

                dataExists.EndDate = DateTime.Now;

                _parkingDBContext.SaveChanges();


                var vehicle = _parkingDBContext.Vehicles
                                           .Where(x => x.LicenseNo == license && !x.ProvidedBy.HasValue && !x.ProvidedDate.HasValue);

                if (vehicle.Any())
                {
                    vehicle.SingleOrDefault().DeleteOn = DateTime.Now;
                }

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
