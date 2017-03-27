using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Agenda.Model;

namespace Agenda.Seguridad
{
    public class GestorSeguridad
    {
        public static bool Autenticar(string usuario, string password)
        {
            using (AgendaModel db = new AgendaModel())
            {
                var encryptedPass = EncriptarPassword(password, Algoritmo.SHA1);
                var user = db.Usuario.Where(u => u.Nombre == usuario && u.Password == encryptedPass).FirstOrDefault();

                return (user != null);
            }
        }
        public static string EncriptarPassword(string password, Algoritmo algoritmo)
        {
            HashAlgorithm hashA;

            switch (algoritmo)
            {
                case Algoritmo.SHA1:
                    {
                        hashA = SHA1.Create();
                        break;
                    }
                default:
                    {
                        throw new Exception("opcion no implementada");
                    }
            }

            var a1 = SHA1CryptoServiceProvider.Create();
            var a2 = a1.ComputeHash(Encoding.UTF8.GetBytes(password));
            var a3 = a2.Select(x => x.ToString("X2"));
            var a4 = string.Join("", a3);

            return a4;
        }
    }

    public enum Algoritmo
    {
        SHA1
    }
}
