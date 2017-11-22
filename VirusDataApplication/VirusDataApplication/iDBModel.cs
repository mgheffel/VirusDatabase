using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace VirusDataApplication{

    public interface iDBModel{
        DataSet sendQuery(string selectSQLStatement);

        DataSet sendUpdate(string updateSQLStatement);

        DataSet sendInsert(string insertSQLStatement);

        DataSet sendDelete(string deleteSQLStatement);
    }
}
