using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapatillasVentas.Core.Entities;

namespace ZapatillasVentas.Core.Interfaces
{
    public interface IZapatillaRepository
    {
        Task<IEnumerable<Zapatilla>> GetAllAsync();
        Task<Zapatilla> GetByIdAsync(int id);
        Task AddAsync(Zapatilla zapatilla);
        Task UpdateAsync(Zapatilla zapatilla);
        Task DeleteAsync(int id);
    }
}

