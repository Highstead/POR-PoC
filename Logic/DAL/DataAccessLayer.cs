using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoR.Logic.DAL
{
    sealed partial class DataAccessLayer
    {
        public string ConnectionString { get; private set; }
        
        public DataAccessLayer()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["PoREntities"].ConnectionString;
        }

        public DataAccessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
