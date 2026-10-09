using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_7_10_26.Modelos;

namespace PROYECTO_7_10_26.Data
{
    public class DatosUsuarios
    {
        public void GuardarUsuario(Usuarios usuario)
        {
            using (var context = new AppDbContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
           
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            using (var context = new AppDbContext())
            {
                return context.Usuarios.ToList();
            }
        }
    }
}
