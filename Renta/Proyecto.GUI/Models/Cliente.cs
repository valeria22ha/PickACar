using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.GUI.Models
{
    public class Cliente
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe de ingresar un correo")]
        [EmailAddress(ErrorMessage = "Debe de introducir un Correo valido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Ingrese su una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Tipo { get; set; }

        public static bool VerficarLogin(Cliente pDatos)
        {
            Proyecto.BLL.Metodos.MCliente lvClient = new BLL.Metodos.MCliente();
            DATOS.Cliente AuthData = new DATOS.Cliente() { Correo = pDatos.Correo, Password = pDatos.Password };
            var result = lvClient.AutentificarCliente(AuthData);
            //si es verdadero, guardar sessiones de autentificación.
            return result;
        }
    }
}
