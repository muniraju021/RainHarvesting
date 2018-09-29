using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainHarvestQuiz.UI
{
    public partial class QuizMainForm : Form
    {
        QuestionarieForm _questionarieFrm = null;
        public Timer timer = new Timer();

        public QuizMainForm()
        {
            InitializeComponent();
            
        }
        
        private void QuizMainForm_Load(object sender, EventArgs e)
        {           
            _questionarieFrm = new QuestionarieForm();
            _questionarieFrm.TopLevel = false;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(_questionarieFrm);
            _questionarieFrm.Show();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
                        
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ResultPage objResultPage = new ResultPage("Play", "Start the Quiz");
            objResultPage.ShowDialog();
            
            _questionarieFrm.StartTimer();
        }

        private void Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _questionarieFrm.StartTimer();
        }
    }
}
