﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapatillasVentas.Core.Entities
{
    public class Zapatilla
    {
        public int Id { get; set; }  
        public string Marca { get; set; }  
        public string Modelo { get; set; }  
        public decimal Precio { get; set; }  
        public int Stock { get; set; }  
    }
}
