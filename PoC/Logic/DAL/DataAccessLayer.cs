using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoR.Logic.DAL
{
    /// <summary>
    /// Data access layer for our Web service.  In many cases i'd consider moving this out on its
    /// own.  Some also might argue with breaking apart the Booked items, clients, and items into
    /// their own DAL classes.  
    /// 
    /// This would make particular sense if we were to do something like move these to their own
    /// database in order to scale horizontally.  This of course does not make sense for this 
    /// project becauset he performance gains would be lost, and then some to the loose connections
    /// between the two.  Also we're using MSSQL which is traditionally like most RDBMS' a vertical
    /// scaling object.
    /// 
    /// Additionally, the Entity framework sits somewhere between BL and DAL and blurs the separation
    /// of BL and DAL.  
    /// </summary>
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
