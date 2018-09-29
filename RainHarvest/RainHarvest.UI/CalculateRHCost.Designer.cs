namespace RainHarvest.UI
{
    partial class CalculateRHCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateRHCost));
            this.drpDownPlotAreaSqm = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drpDownPlotAreaSqft = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCalculate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.drpDownConsumerUsage = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drpDownPlotAreaSqm
            // 
            this.drpDownPlotAreaSqm.BackColor = System.Drawing.Color.Transparent;
            this.drpDownPlotAreaSqm.BorderRadius = 5;
            this.drpDownPlotAreaSqm.DisabledColor = System.Drawing.Color.Gray;
            this.drpDownPlotAreaSqm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDownPlotAreaSqm.ForeColor = System.Drawing.Color.White;
            this.drpDownPlotAreaSqm.Items = new string[0];
            this.drpDownPlotAreaSqm.Location = new System.Drawing.Point(301, 45);
            this.drpDownPlotAreaSqm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpDownPlotAreaSqm.Name = "drpDownPlotAreaSqm";
            this.drpDownPlotAreaSqm.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.drpDownPlotAreaSqm.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.drpDownPlotAreaSqm.selectedIndex = -1;
            this.drpDownPlotAreaSqm.Size = new System.Drawing.Size(133, 65);
            this.drpDownPlotAreaSqm.TabIndex = 0;
            this.drpDownPlotAreaSqm.onItemSelected += new System.EventHandler(this.drpDownPlotAreaSqm_onItemSelected);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(143, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 26);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Plot Area in Sqm";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(134, 154);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(148, 26);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Plot Area in Sqft";
            // 
            // drpDownPlotAreaSqft
            // 
            this.drpDownPlotAreaSqft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drpDownPlotAreaSqft.BackColor = System.Drawing.Color.Transparent;
            this.drpDownPlotAreaSqft.BorderRadius = 5;
            this.drpDownPlotAreaSqft.DisabledColor = System.Drawing.Color.Gray;
            this.drpDownPlotAreaSqft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDownPlotAreaSqft.ForeColor = System.Drawing.Color.White;
            this.drpDownPlotAreaSqft.Items = new string[0];
            this.drpDownPlotAreaSqft.Location = new System.Drawing.Point(301, 137);
            this.drpDownPlotAreaSqft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpDownPlotAreaSqft.Name = "drpDownPlotAreaSqft";
            this.drpDownPlotAreaSqft.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.drpDownPlotAreaSqft.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.drpDownPlotAreaSqft.selectedIndex = -1;
            this.drpDownPlotAreaSqft.Size = new System.Drawing.Size(133, 65);
            this.drpDownPlotAreaSqft.TabIndex = 2;
            this.drpDownPlotAreaSqft.onItemSelected += new System.EventHandler(this.drpDownPlotAreaSqft_onItemSelected);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.BorderRadius = 5;
            this.btnCalculate.ButtonText = "Calculate";
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalculate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Iconimage")));
            this.btnCalculate.Iconimage_right = null;
            this.btnCalculate.Iconimage_right_Selected = null;
            this.btnCalculate.Iconimage_Selected = null;
            this.btnCalculate.IconMarginLeft = 0;
            this.btnCalculate.IconMarginRight = 0;
            this.btnCalculate.IconRightVisible = false;
            this.btnCalculate.IconRightZoom = 0D;
            this.btnCalculate.IconVisible = false;
            this.btnCalculate.IconZoom = 90D;
            this.btnCalculate.IsTab = true;
            this.btnCalculate.Location = new System.Drawing.Point(193, 321);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.btnCalculate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.btnCalculate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalculate.selected = false;
            this.btnCalculate.Size = new System.Drawing.Size(241, 51);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.Textcolor = System.Drawing.Color.White;
            this.btnCalculate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // drpDownConsumerUsage
            // 
            this.drpDownConsumerUsage.BackColor = System.Drawing.Color.Transparent;
            this.drpDownConsumerUsage.BorderRadius = 5;
            this.drpDownConsumerUsage.DisabledColor = System.Drawing.Color.Gray;
            this.drpDownConsumerUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDownConsumerUsage.ForeColor = System.Drawing.Color.White;
            this.drpDownConsumerUsage.Items = new string[0];
            this.drpDownConsumerUsage.Location = new System.Drawing.Point(301, 229);
            this.drpDownConsumerUsage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpDownConsumerUsage.Name = "drpDownConsumerUsage";
            this.drpDownConsumerUsage.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(7)))), ((int)(((byte)(117)))));
            this.drpDownConsumerUsage.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.drpDownConsumerUsage.selectedIndex = -1;
            this.drpDownConsumerUsage.Size = new System.Drawing.Size(133, 65);
            this.drpDownConsumerUsage.TabIndex = 8;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(105, 243);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(190, 26);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Water Usage Per Day";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(440, 252);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(26, 21);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "lts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 457);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CalculateRHCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.drpDownConsumerUsage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.drpDownPlotAreaSqft);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.drpDownPlotAreaSqm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculateRHCost";
            this.Text = "S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown drpDownPlotAreaSqm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown drpDownPlotAreaSqft;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalculate;
        private Bunifu.Framework.UI.BunifuDropdown drpDownConsumerUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}