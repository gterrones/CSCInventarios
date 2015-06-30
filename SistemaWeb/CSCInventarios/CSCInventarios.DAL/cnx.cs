using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CSCInventarios.DAL
{
    public abstract class cnx
    {
        public cnx()
        {
           DataBase = EnterpriseLibraryContainer.Current.GetInstance<Database>();     
        }

        protected Database DataBase { get; set; }
    }
}
