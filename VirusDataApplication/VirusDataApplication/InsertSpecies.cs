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
    public partial class InsertSpecies : Form
    {

        private Controller c;

        public InsertSpecies(Controller co)
        {
            c = co;
            InitializeComponent();
        }

        private void InsertSpecies_Load(object sender, EventArgs e)
        {

        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            if (uxAbbreviation.Text.Length > 0 && uxName.Text.Length > 0 && uxGenus.Text.Length > 0 && uxFamily.Text.Length > 0 && uxOrder.Text.Length > 0)
            {
                uxAddButton.Enabled = true;
            }
            else uxAddButton.Enabled = false;
        }
    }
}
