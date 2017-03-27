using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Seguridad;

namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GestorSeguridad.Autenticar("admin", "Admin1");
            var some = GestorSeguridad.EncriptarPassword("Admin1", Algoritmo.SHA1);
        }
    }
}
