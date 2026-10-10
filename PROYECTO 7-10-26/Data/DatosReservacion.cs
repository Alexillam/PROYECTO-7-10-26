using PROYECTO_7_10_26.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_7_10_26.Data
{
    public class DatosReservacion
    {
        public void GuardarReservacion(Reservaciones reservaciones)
        {
            using (var context = new AppDbContext())
            {
                context.Reservaciones.Add(reservaciones);
                context.SaveChanges();
            }
        }

        public List<ReservacionesDTO> ObtenerReservaciones()
        {
            using (var context = new AppDbContext())
            {
                var consulta= from r in context.Reservaciones
                              join s in context.Salas
                              on r.IdSala equals s.Id
                              join u in context.Usuarios
                              on r.IdUsuario equals u.Id

                              select new ReservacionesDTO
                              {
                                  NombreUsuario = u.Nombre,
                                  NombreSala = s.NombreSala,
                                  FechaReservacion = r.Fecha
                              };

                return consulta.ToList();
            }
        }
    }
}
