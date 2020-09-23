using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexasTSA.Services.TsaYourWay.Catalog.Storage
{
    public class SqlClient
    {
        public void Insert(
            string sqlCommand,
            Dictionary<string, object> parameters)
        {
            if (String.IsNullOrEmpty(sqlCommand)) {
                throw new ArgumentNullException(nameof(sqlCommand));
            }

        }
    }
}
