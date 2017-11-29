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

        private InterfaceV2 iv2;

        private DataTable publishers;

        private string speciesName;

        private bool strainExist = false;
        private bool researcherExist = false;
        private bool publisherExist = false;
        public InsertPublication(Controller c, string specName, InterfaceV2 iv)
        {
            speciesName = specName;
            iv2 = iv;
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
            if (uxTitle.Text.Length > 0 && uxYear.Text.Length > 0  && uxResearchers.Items.Count > 0 && uxStrains.Items.Count > 0 && researcherExist && strainExist && publisherExist)
            {
                uxAddPublicationButton.Enabled = true;
            }
            else uxAddPublicationButton.Enabled = false;
        }

        private void uxAddPublicationButton_Click(object sender, EventArgs e)
        {
            //Adding publication info to Publications table.
            con.sendNonQuery("INSERT INTO Publications(pYear, title) VALUES ('" + uxYear.Text + "', '" + uxTitle.Text + "');");
            DataTable pubID = con.SendTheWave("SELECT pubID from Publications where title = '" + uxTitle.Text + "'");
            //Adding info to the publishers table (if necessary) and adding to the linking table Publisher_Publication
            foreach (ListViewItem item in uxPublishers.Items)
            {
                string p = item.Text;
                if (!uxPublisherDrop.Items.Contains(p))
                {
                    con.sendNonQuery("INSERT INTO Publishers(name) VALUES ('" + p + "');");
                }
                DataTable publisherID = con.SendTheWave("SELECT publisherID from Publishers WHERE name = '" + p + "'");
                con.sendNonQuery("INSERT INTO Publisher_Publication VALUES ('" + publisherID.Rows[0][0].ToString() + "', '" + pubID.Rows[0][0].ToString() + "');");
            }
            //Adding to the Researchers table (if necessary) and adding to the linking table Publication_Researcher
            foreach(Tuple<string,string,string> r in researchers)
            {
                con.sendNonQuery("INSERT INTO Researchers(rName, rEmail, rOrg) VALUES ('" + r.Item1 + "', '" + r.Item2 + "', '" + r.Item3 + "');");
                DataTable rID = con.SendTheWave("SELECT rID from Researchers where rName = '" + r.Item1 + "' and rEmail = '" + r.Item2 + "' and rOrg = '" + r.Item3 + "'");
                con.sendNonQuery("INSERT INTO Publication_Researcher VALUES ('" + pubID.Rows[0][0].ToString() + "', '" + rID.Rows[0][0].ToString() + "');");
            }
            //Now adding Strains and Strain_Publication
            foreach(Tuple<string,string,string> st in strains)
            {
                DataTable d = con.SendTheWave("SELECT specID FROM Species WHERE sName = '" + speciesName + "'");
                string sendString = "INSERT INTO Strains VALUES ('" + st.Item1 + "', '" + st.Item2 + "', " + d.Rows[0][0].ToString() + ", '" + st.Item3 + "')";
                con.sendNonQuery(sendString);
               con.sendNonQuery("INSERT INTO Strain_Publication VALUES ('" + st.Item1 + "', " + pubID.Rows[0][0].ToString() + ");"); 
            }
            iv2.addEverything();
        }

        private void uxAddPublisherButton_Click(object sender, EventArgs e)
        {
            publisherExist = true;
            uxPublishers.Items.Add(uxPublisherDrop.Text);
            uxPublisherDrop.SelectedIndex = -1;
            ButtonEnable(this, new EventArgs());

        }

        private void uxPublisherDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxPublisherDrop.Text.Length > 0)
            {
                uxAddPublisherButton.Enabled = true;
            }
            else uxAddPublisherButton.Enabled = false;
        }
    }
}
