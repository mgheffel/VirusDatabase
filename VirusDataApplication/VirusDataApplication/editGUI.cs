using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusDataApplication
{
    public partial class editGUI : Form
    {
        string tableName;
        Controller c;
        public editGUI(string name, string val, Controller control)
        {
            InitializeComponent();
            tableName = name;
            c = control;
            
        }
    }
}
