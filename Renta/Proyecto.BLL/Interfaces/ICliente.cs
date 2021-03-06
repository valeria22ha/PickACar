﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface ICliente
    {
        List<Cliente> ListarClientes();

        Cliente BuscarCliente(int idCliente);

        bool InsertarCliente(Cliente cliente);

        void ActualizarCliente(Cliente cliente);

        void EliminarCliente(int idCliente);

         
    }
}
