using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto.DAL;
using ServiceStack.OrmLite;

namespace Lec03.DAL.Metodos
{
    public class MBase
    {
        public OrmLiteConnectionFactory _conexion;
        public IDbConnection _db;
        
        public MBase()
        {
                _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion,
               SqlServerDialect.Provider);
                _db = _conexion.Open();
        }
    }
}