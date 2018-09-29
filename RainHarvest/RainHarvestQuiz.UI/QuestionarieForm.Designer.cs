namespace RainHarvestQuiz.UI
{
    partial class QuestionarieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionarieForm));
            this.lblQuestion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAnwerA = new System.Windows.Forms.Button();
            this.btnAnwerB = new System.Windows.Forms.Button();
            this.btnAnwerD = new System.Windows.Forms.Button();
            this.btnAnwerC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(156)))));
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(61, 48);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(943, 303);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Do you know how much water that you use everyday goes out as waste?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.UseCompatibleTextRendering = true;
            // 
            // btnAnwerA
            // 
            this.btnAnwerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.btnAnwerA.FlatAppearance.BorderSize = 0;
            this.btnAnwerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnwerA.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.btnAnwerA.ForeColor = System.Drawing.Color.White;
            this.btnAnwerA.Location = new System.Drawing.Point(119, 445);
            this.btnAnwerA.Name = "btnAnwerA";
            this.btnAnwerA.Size = new System.Drawing.Size(361, 76);
            this.btnAnwerA.TabIndex = 6;
            this.btnAnwerA.Text = "50%";
            this.btnAnwerA.UseVisualStyleBackColor = false;
            this.btnAnwerA.Click += new System.EventHandler(this.btnAnwerA_Click);
            // 
            // btnAnwerB
            // 
            this.btnAnwerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.btnAnwerB.FlatAppearance.BorderSize = 0;
            this.btnAnwerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnwerB.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.btnAnwerB.ForeColor = System.Drawing.Color.White;
            this.btnAnwerB.Location = new System.Drawing.Point(583, 445);
            this.btnAnwerB.Name = "btnAnwerB";
            this.btnAnwerB.Size = new System.Drawing.Size(361, 76);
            this.btnAnwerB.TabIndex = 7;
            this.btnAnwerB.Text = "80%";
            this.btnAnwerB.UseVisualStyleBackColor = false;
            this.btnAnwerB.Click += new System.EventHandler(this.btnAnwerA_Click);
            // 
            // btnAnwerD
            // 
            this.btnAnwerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.btnAnwerD.FlatAppearance.BorderSize = 0;
            this.btnAnwerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnwerD.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.btnAnwerD.ForeColor = System.Drawing.Color.White;
            this.btnAnwerD.Location = new System.Drawing.Point(583, 574);
            this.btnAnwerD.Name = "btnAnwerD";
            this.btnAnwerD.Size = new System.Drawing.Size(361, 76);
            this.btnAnwerD.TabIndex = 9;
            this.btnAnwerD.Text = "5%";
            this.btnAnwerD.UseVisualStyleBackColor = false;
            this.btnAnwerD.Click += new System.EventHandler(this.btnAnwerA_Click);
            // 
            // btnAnwerC
            // 
            this.btnAnwerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.btnAnwerC.FlatAppearance.BorderSize = 0;
            this.btnAnwerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnwerC.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.btnAnwerC.ForeColor = System.Drawing.Color.White;
            this.btnAnwerC.Location = new System.Drawing.Point(120, 574);
            this.btnAnwerC.Name = "btnAnwerC";
            this.btnAnwerC.Size = new System.Drawing.Size(361, 76);
            this.btnAnwerC.TabIndex = 8;
            this.btnAnwerC.Text = "25%";
            this.btnAnwerC.UseVisualStyleBackColor = false;
            this.btnAnwerC.Click += new System.EventHandler(this.btnAnwerA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // QuestionarieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1064, 720);
            this.Controls.Add(this.btnAnwerD);
            this.Controls.Add(this.btnAnwerC);
            this.Controls.Add(this.btnAnwerB);
            this.Controls.Add(this.btnAnwerA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionarieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionarieForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuestionarieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblQuestion;
        private System.Windows.Forms.Button btnAnwerA;
        private System.Windows.Forms.Button btnAnwerB;
        private System.Windows.Forms.Button btnAnwerD;
        private System.Windows.Forms.Button btnAnwerC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}