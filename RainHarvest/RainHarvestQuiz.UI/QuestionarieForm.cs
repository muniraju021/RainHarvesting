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
    public partial class QuestionarieForm : Form
    {
        private int _questionIndex = 0;
        Timer tick = new Timer();
        private QuizMainForm _parentForm = null;
        Color _btnBackColor = Color.FromArgb(66, 58, 70);
        Color _btnSelectedColor = Color.FromArgb(32, 107, 156);

        public QuestionarieForm()
        {
            InitializeComponent();
            tick.Interval = 1000;
            tick.Tick += Tick_Tick;           
        }

        public void StartTimer()
        {            
            tick.Start();
        }

        public void StopTimer()
        {
            tick.Stop();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {            
            var intTick = Convert.ToInt32(_parentForm.lblTimer.Text);
            intTick = intTick - 1;
            _parentForm.lblTimer.Text = intTick > 0 ? intTick.ToString() : "0";
            if(intTick <= 0)
            {
                StopTimer();
                var question = CacheManager.Questionaries[_questionIndex];
                var resultForm = new ResultPage("Timeout", question.Item3);
                resultForm.ShowDialog();
                LoadQuestion();
                if (_questionIndex > 1)
                    StartTimer();
            }
        }

        private void btnAnwerA_Click(object sender, EventArgs e)
        {
            if (tick.Enabled)
            {
                StopTimer();

                var btn = (sender as Button);
                btn.BackColor = _btnSelectedColor;
                var question = CacheManager.Questionaries[_questionIndex];                
                if (btn.Text == question.Item3)
                {
                    var resultForm = new ResultPage("Correct", string.Empty);
                    resultForm.ShowDialog();
                }
                else
                {
                    var resultForm = new ResultPage("Wrong", question.Item3);
                    resultForm.ShowDialog();
                }
                LoadQuestion();
                btn.BackColor = _btnBackColor;

                if (_questionIndex > 1)
                    StartTimer();
                                
            }
            
        }

        private void QuestionarieForm_Load(object sender, EventArgs e)
        {
            _parentForm = this.ParentForm as QuizMainForm;
            LoadQuestion();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadQuestion()
        {
            if (_questionIndex == CacheManager.Questionaries.Count)
            {
                var resultForm = new ResultPage("ThankYou", string.Empty);
                resultForm.ShowDialog();                
                _questionIndex = 1;
                var question = CacheManager.Questionaries[_questionIndex];
                lblQuestion.Text = question.Item1;
                btnAnwerA.Text = question.Item2[0];
                btnAnwerB.Text = question.Item2[1];
                btnAnwerC.Text = question.Item2[2];
                btnAnwerD.Text = question.Item2[3];
                _parentForm.lblTimer.Text = "15";
                _parentForm.timer.Start();
            }
            else
            {
                _questionIndex += 1;
                var question = CacheManager.Questionaries[_questionIndex];
                lblQuestion.Text = question.Item1;
                btnAnwerA.Text = question.Item2[0];
                btnAnwerB.Text = question.Item2[1];
                btnAnwerC.Text = question.Item2[2];
                btnAnwerD.Text = question.Item2[3];
                _parentForm.lblTimer.Text = "15";                
            }
        }
    }
}
