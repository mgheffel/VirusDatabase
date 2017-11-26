using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace VirusDataApplication{

    public interface iDBModel{
        DataTable sendQuery(string selectSQLStatement);

        bool sendUpdate(string updateSQLStatement);

        bool sendExecuteStatement(string insertSQLStatement);

        bool sendDelete(string deleteSQLStatement);
    }
}
