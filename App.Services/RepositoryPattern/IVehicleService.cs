using App.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.RepositoryPattern
{
    public interface IVehicleService
    {
        Task<List<VehicleDto>> GetVehicles();

        Task<VehicleDto> GetOne(int id);
    }
}
