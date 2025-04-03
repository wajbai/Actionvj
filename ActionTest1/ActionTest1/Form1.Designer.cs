using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ActionTest1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            ShowAboutVijay();
        }

        private void ShowAboutVijay()
        {
            string vijayDetails = "Thalapathy Vijay - Tamil Cinema Superstar\n\n" +
                                  "Full Name: Joseph Vijay Chandrasekhar\n" +
                                  "Born: June 22, 1974 (Chennai, India)\n" +
                                  "Profession: Actor, Singer, Dancer, Philanthropist\n" +
                                  "Nickname: Thalapathy (Commander)\n\n" +
                                  "Career Highlights:\n" +
                                  "- One of the highest-paid actors in Indian cinema.\n" +
                                  "- Debuted as a lead in Naalaiya Theerpu (1992).\n" +
                                  "- Gained fame with Poove Unakkaga (1996).\n" +
                                  "- Starred in blockbuster films like Ghilli, Thuppakki, Mersal, Master, and Leo.\n" +
                                  "- Known for mass appeal, action-packed performances, and dance skills.\n\n" +
                                  "Awards & Achievements:\n" +
                                  "- Won multiple Vijay Awards, Tamil Nadu State Film Awards, and SIIMA Awards.\n" +
                                  "- Featured in Forbes India’s Celebrity 100 list multiple times.\n" +
                                  "- Honored with a Doctorate from Dr. M.G.R. Educational and Research Institute.\n\n" +
                                  "Philanthropy & Social Work:\n" +
                                  "- Runs Vijay Makkal Iyakkam, a welfare organization.\n" +
                                  "- Involved in education, medical aid, and disaster relief efforts.";
            MessageBox.Show(vijayDetails, "About Vijay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
