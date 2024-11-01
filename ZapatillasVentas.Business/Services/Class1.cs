using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapatillasVentas.Business.Services
{
    public class ZapatillaService
    {
        private readonly IZapatillaRepository _zapatillaRepository;

        public ZapatillaService(IZapatillaRepository zapatillaRepository)
        {
            _zapatillaRepository = zapatillaRepository;
        }

        // Métodos de negocio como Obtener, Crear, Actualizar y Eliminar
    }
}
