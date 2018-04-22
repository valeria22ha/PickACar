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
        [Required(ErrorMessage ="Es necesario Insertar un dato")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Es necesario Insertar un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario Insertar un Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Es necesario Insertar un Telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es necesario Insertar una Direccion")]
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
            BLL.Metodos.MCliente lvClient = new BLL.Metodos.MCliente();
            DATOS.Cliente AuthData = new DATOS.Cliente() { Correo = pDatos.Correo, Password = pDatos.Password};
            var result = lvClient.AutentificarCliente(AuthData);
            //TODO: Variables de session 
            return result;
        }
    }
}
