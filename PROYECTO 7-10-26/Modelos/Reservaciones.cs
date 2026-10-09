using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_7_10_26.Modelos
{
    public class Reservaciones
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSala { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
