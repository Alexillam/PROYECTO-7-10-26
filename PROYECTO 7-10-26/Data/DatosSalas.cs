using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_7_10_26.Modelos;

namespace PROYECTO_7_10_26.Data
{
    public class DatosSalas
    {
        public void GuardarSala(Salas sala)
        {
            using (var context = new AppDbContext())
            {
                context.Salas.Add(sala);
                context.SaveChanges();
            }
        }

        public List<Salas> ObtenerSalas()
        {
            using (var context = new AppDbContext())
            {
                return context.Salas.ToList();
            }
        }
    }
}
