using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.RepositoryPattern
{
    public interface IParkingService
    {
        int NumberOfLot(int level);

        Task<bool> Assign(string license, int level, int cardNo);

        bool ReAssign(string license, int level, int cardNo);
    }
}
