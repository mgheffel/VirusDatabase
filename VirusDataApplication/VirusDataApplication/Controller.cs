using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace VirusDataApplication
{
    public class Controller
    {
        iDBModel model;
        public Controller(iDBModel m)
        {
            model = m;
        }
        public string tempQuery(string a)
        {
            string queryStatement = "SELECT * FROM OpenReadingFrames WHERE strainID = " + a;
            DataSet result = model.sendQuery(queryStatement);
            return null;
        }
        //code will go here
    }
}
