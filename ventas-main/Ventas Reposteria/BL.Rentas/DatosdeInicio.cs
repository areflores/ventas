using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    { 
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Pasteles Frios";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Refrescos";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Donas";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Polvorones";
            contexto.Categorias.Add(categoria4);

            base.Seed(contexto);
        }
    }
}
