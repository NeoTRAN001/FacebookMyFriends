using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookMyFriends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            Token token = new Token();
            token.Visible = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new Info().Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new Search().Visible = true;
        }
    }
}
