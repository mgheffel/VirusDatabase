using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusDataApplication{

    public interface iDBModel{
        string sendQuery(string selectSQLStatement);

        string sendUpdate(string updateSQLStatement);
    }
}
