using System.Xml.Schema;

namespace Hasan.Badr.harjoitus13
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines();
            string[] tytot = File.ReadAllLines();
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string s in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on" + laskurip + " .suosituin poikien nimi vuonna 2020 ";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuomma 2020";
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi eei löytymyt suositmpien nimen joukosta :-(";
                VastausLB.Visible = true;
            }

        }
    }
}