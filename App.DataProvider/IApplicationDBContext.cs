//using Domain.Master;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        //DbSet<AppSetting> AppSettings { get; set; }

        Task<int> SaveChangesAsync();
    }
}