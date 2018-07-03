using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;


namespace Proyecto.DAL.Interfaces
{
    public interface ICliente
    {
        List<Cliente> ListarClientes();

        Cliente BuscarCliente(int idCliente);

        void InsertarCliente(Cliente cliente);

        void ActualizarCliente(Cliente cliente);

        void EliminarCliente(int idCliente);

        Proyecto.DATOS.Cliente AutentificarCliente(string LoginUser, string Password);

        bool CheckEmailExists(string pEmail, int pIdClient);

        string ObtenerPasswordCliente(string pEmail);

        int ObtenerCedula(string email);

    }
}
