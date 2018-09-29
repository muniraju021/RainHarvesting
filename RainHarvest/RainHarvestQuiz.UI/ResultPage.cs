using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainHarvestQuiz.UI
{
    public partial class ResultPage : Form
    {
        private string _result = string.Empty;
        private string _correctVal = string.Empty;

        public ResultPage(string result,string correctValue)
        {
            InitializeComponent();
            this._result = result;
            this._correctVal = correctValue;
        }

        private void ResultPage_Load(object sender, EventArgs e)
        {
            if(_result == "Wrong")
            {
                Bitmap img = new Bitmap(@".\Images\Wrong.png");
                picBxResult.BackgroundImage = img;
                picBxResult.BackgroundImageLayout = ImageLayout.Stretch;
                lblResult.Text = $"Correct Answer: {_correctVal}";
                btnAnwerB.Text = "Continue";
            }
            else if(_result == "Correct")
            {
                Bitmap img = new Bitmap(@".\Images\Correct.png");
                picBxResult.BackgroundImage = img;
                picBxResult.BackgroundImageLayout = ImageLayout.Stretch;
                lblResult.Text = $"Perfect!";
                btnAnwerB.Text = "Continue";
            }
            else if(_result == "Timeout")
            {
                Bitmap img = new Bitmap(@".\Images\Wrong.png");
                picBxResult.BackgroundImage = img;
                picBxResult.BackgroundImageLayout = ImageLayout.Stretch;
                lblResult.Text = $"Correct Answer: {_correctVal}";
                btnAnwerB.Text = "Continue";
            }
            else if(_result == "ThankYou")
            {
                //Bitmap img = new Bitmap(@".\Images\ThankYou.png");
                //picBxResult.BackgroundImage = img;
                //picBxResult.BackgroundImageLayout = ImageLayout.Stretch;
                picBxResult.BackgroundImage = null;
                lblResult.Text = $"Thank you !!!";
                btnAnwerB.Text = "Continue";
            }
            else if(_result == "Play")
            {
                Bitmap img = new Bitmap(@".\Images\QuizImage.png");
                picBxResult.BackgroundImage = img;
                picBxResult.BackgroundImageLayout = ImageLayout.Stretch;
                lblResult.Text = $"Start the Quiz";
                btnAnwerB.Text = "Play";
            }
        }

        private void btnAnwerB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
