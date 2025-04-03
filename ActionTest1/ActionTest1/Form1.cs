
using System.Windows.Forms; // Ensure this is included

namespace ActionTest1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAboutVijay;
        private TextBox txtVijayDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAboutVijay = new System.Windows.Forms.Label();
            this.txtVijayDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAboutVijay
            // 
            this.lblAboutVijay.AutoSize = true;
            this.lblAboutVijay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAboutVijay.Location = new System.Drawing.Point(20, 20);
            this.lblAboutVijay.Name = "lblAboutVijay";
            this.lblAboutVijay.Size = new System.Drawing.Size(150, 19);
            this.lblAboutVijay.Text = "About Vijay";
            // 
            // txtVijayDetails
            // 
            this.txtVijayDetails.Multiline = true;
            this.txtVijayDetails.ReadOnly = true;
            this.txtVijayDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVijayDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtVijayDetails.Location = new System.Drawing.Point(20, 50);
            this.txtVijayDetails.Size = new System.Drawing.Size(580, 200);
            this.txtVijayDetails.Text = "Thalapathy Vijay - Tamil Cinema Superstar\r\n\r\n" +
                                   "Full Name: Joseph Vijay Chandrasekhar\r\n" +
                                   "Born: June 22, 1974 (Chennai, India)\r\n" +
                                   "Profession: Actor, Singer, Dancer, Philanthropist\r\n" +
                                   "Nickname: Thalapathy (Commander)\r\n\r\n" +
                                   "Career Highlights:\r\n" +
                                   "- One of the highest-paid actors in Indian cinema.\r\n" +
                                   "- Debuted as a lead in Naalaiya Theerpu (1992).\r\n" +
                                   "- Gained fame with Poove Unakkaga (1996).\r\n" +
                                   "- Starred in blockbuster films like Ghilli, Thuppakki, Mersal, Master, and Leo.\r\n" +
                                   "- Known for mass appeal, action-packed performances, and dance skills.\r\n\r\n" +
                                   "Awards & Achievements:\r\n" +
                                   "- Won multiple Vijay Awards, Tamil Nadu State Film Awards, and SIIMA Awards.\r\n" +
                                   "- Featured in Forbes India’s Celebrity 100 list multiple times.\r\n" +
                                   "- Honored with a Doctorate from Dr. M.G.R. Educational and Research Institute.\r\n\r\n" +
                                   "Philanthropy & Social Work:\r\n" +
                                   "- Runs Vijay Makkal Iyakkam, a welfare organization.\r\n" +
                                   "- Involved in education, medical aid, and disaster relief efforts.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.lblAboutVijay);
            this.Controls.Add(this.txtVijayDetails);
            this.Name = "Form1";
            this.Text = "About Vijay";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
