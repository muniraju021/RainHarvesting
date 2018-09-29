namespace RainHarvestQuiz.UI
{
    partial class ResultPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultPage));
            this.btnAnwerB = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBxResult = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnwerB
            // 
            this.btnAnwerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(125)))), ((int)(((byte)(168)))));
            this.btnAnwerB.Font = new System.Drawing.Font("Univers Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.btnAnwerB.ForeColor = System.Drawing.Color.White;
            this.btnAnwerB.Location = new System.Drawing.Point(253, 132);
            this.btnAnwerB.Name = "btnAnwerB";
            this.btnAnwerB.Size = new System.Drawing.Size(117, 34);
            this.btnAnwerB.TabIndex = 8;
            this.btnAnwerB.Text = "Continue..";
            this.btnAnwerB.UseVisualStyleBackColor = false;
            this.btnAnwerB.Click += new System.EventHandler(this.btnAnwerB_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Univers Condensed", 25F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(196, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(241, 96);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Hurray !";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblResult);
            this.bunifuGradientPanel1.Controls.Add(this.btnAnwerB);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(156)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(156)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(438, 215);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picBxResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 213);
            this.panel1.TabIndex = 10;
            // 
            // picBxResult
            // 
            this.picBxResult.Location = new System.Drawing.Point(11, 11);
            this.picBxResult.Name = "picBxResult";
            this.picBxResult.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.picBxResult.Size = new System.Drawing.Size(168, 191);
            this.picBxResult.TabIndex = 0;
            this.picBxResult.TabStop = false;
            // 
            // ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(438, 215);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultPage";
            this.Load += new System.EventHandler(this.ResultPage_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnwerB;
        private System.Windows.Forms.Label lblResult;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBxResult;
    }
}