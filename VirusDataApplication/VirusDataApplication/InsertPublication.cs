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
    public partial class InsertPublication : Form
    {
        private Controller con;

        private List<Tuple<string, string, string>> researchers = new List<Tuple<string, string, string>>();

        private List<Tuple<string, string, string>> strains = new List<Tuple<string, string, string>>();

        private DataTable publishers;

        private bool strainExist = false;
        private bool researcherExist = false;
        public InsertPublication(Controller c)
        {
            con = c;
            InitializeComponent();
            publishers = c.SendTheWave("SELECT DISTINCT name FROM Publishers");
            foreach(DataRow r in publishers.Rows)
            {
                uxPublisherDrop.Items.Add(r[0].ToString());
            }
            
        }

        private void uxAddStrainButton_Click(object sender, EventArgs e)
        {
            InsertStrain inStrain = new InsertStrain(this);
            inStrain.ShowDialog();
        }

        public void AddStrainToList(Tuple<string, string, string> s)
        {
            strains.Add(s);
            uxStrains.Items.Add(s.Item1);
            strainExist = true;
            ButtonEnable(this, new EventArgs());
        }

        public void AddResearcherToList(Tuple<string, string, string> r)
        {
            researchers.Add(r);
            uxResearchers.Items.Add(r.Item1);
            researcherExist = true;
            ButtonEnable(this, new EventArgs());
        }

        private void uxAddResearcherButton_Click(object sender, EventArgs e)
        {
            DataTable orgs = con.SendTheWave("SELECT DISTINCT rOrg from Researchers");
            InsertResearcher ir = new InsertResearcher(orgs, this);
            ir.ShowDialog();
        }

        private void ButtonEnable(object sender, EventArgs e)
        {
            if (uxTitle.Text.Length > 0 && uxYear.Text.Length > 0 && uxPublisherDrop.Text.Length > 0 && uxResearchers.Items.Count > 0 && uxStrains.Items.Count > 0 && researcherExist && strainExist)
            {
                uxAddPublicationButton.Enabled = true;
            }
            else uxAddPublicationButton.Enabled = false;
        }

        private void uxAddPublicationButton_Click(object sender, EventArgs e)
        {
            //Adding publication info to Publications table.
            con.sendNonQuery("INSERT INTO Publications VALUES ('" + uxYear.Text + "', '" + uxTitle.Text + "');");
            //Adding info to the publishers table (if necessary).
            if (!uxPublisherDrop.Items.Contains(uxPublisherDrop.Text))
            {
                con.sendNonQuery("INSERT INTO Publishers VALUES ('" + uxPublisherDrop.Text + "');");
            }
            //Adding info to the Publisher_Publication table
            //con.sendNonQuery("INSERT INTO ");

        }
    }
}
