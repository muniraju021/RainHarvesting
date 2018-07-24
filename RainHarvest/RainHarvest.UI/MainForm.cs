using RainHarvest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainHarvest.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
                        
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var calForm = new CalculateRHCost();
            calForm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(calForm);
            calForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            calForm.Dock = DockStyle.Fill;
            calForm.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            
        }
    }
}
