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
    public partial class InsertResearcher : Form
    {
        private InsertPublication ip;
        private DataTable orgs;

        public InsertResearcher(DataTable o, InsertPublication ipub)
        {
            orgs = o;
            ip = ipub;
            InitializeComponent();
            foreach (DataRow d in orgs.Rows)
            {
                uxOrganization.Items.Add(d[0].ToString());
            }
        }

        private void uxAddResearcher_Click(object sender, EventArgs e)
        {
            ip.AddResearcherToList(new Tuple<string, string, string>(uxName.Text, uxEmail.Text, uxOrganization.Text));
            this.Close();
        }

        private void ButtonEnable(object sender, EventArgs e)
        {
            if (uxName.Text.Length > 0 && uxEmail.Text.Length > 0 && uxOrganization.Text.Length > 0)
            {
                uxAddResearcher.Enabled = true;
            }
            else uxAddResearcher.Enabled = false;
        }
    }
}
