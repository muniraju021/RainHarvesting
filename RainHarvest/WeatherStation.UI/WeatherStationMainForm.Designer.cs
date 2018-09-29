namespace WeatherStation.UI
{
    partial class WeatherStationMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherStationMainForm));
            this.bunifuDrgCntrl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.picBxWindDirection = new System.Windows.Forms.PictureBox();
            this.lblWindSpeed = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOutdoorHumidity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIndoorHumidity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRainfallInmm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOutdoorTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIndoorTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxWindDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDrgCntrl
            // 
            this.bunifuDrgCntrl.Fixed = true;
            this.bunifuDrgCntrl.Horizontal = true;
            this.bunifuDrgCntrl.TargetControl = this.MainPanel;
            this.bunifuDrgCntrl.Vertical = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.linkLblClose);
            this.MainPanel.Controls.Add(this.picBxWindDirection);
            this.MainPanel.Controls.Add(this.lblWindSpeed);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel7);
            this.MainPanel.Controls.Add(this.lblOutdoorHumidity);
            this.MainPanel.Controls.Add(this.lblIndoorHumidity);
            this.MainPanel.Controls.Add(this.lblRainfallInmm);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel3);
            this.MainPanel.Controls.Add(this.lblOutdoorTemp);
            this.MainPanel.Controls.Add(this.lblIndoorTemp);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1386, 788);
            this.MainPanel.TabIndex = 2;
            // 
            // linkLblClose
            // 
            this.linkLblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.linkLblClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.linkLblClose.Location = new System.Drawing.Point(1284, 9);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(58, 25);
            this.linkLblClose.TabIndex = 12;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Close";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // picBxWindDirection
            // 
            this.picBxWindDirection.Image = ((System.Drawing.Image)(resources.GetObject("picBxWindDirection.Image")));
            this.picBxWindDirection.Location = new System.Drawing.Point(1087, 556);
            this.picBxWindDirection.Name = "picBxWindDirection";
            this.picBxWindDirection.Size = new System.Drawing.Size(123, 123);
            this.picBxWindDirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxWindDirection.TabIndex = 10;
            this.picBxWindDirection.TabStop = false;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed.Font = new System.Drawing.Font("Univers Condensed", 45F, System.Drawing.FontStyle.Bold);
            this.lblWindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblWindSpeed.Location = new System.Drawing.Point(777, 556);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(177, 70);
            this.lblWindSpeed.TabIndex = 7;
            this.lblWindSpeed.Text = "0.346";
            this.lblWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Univers Condensed", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(857, 618);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(86, 54);
            this.bunifuCustomLabel7.TabIndex = 8;
            this.bunifuCustomLabel7.Text = "kph";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOutdoorHumidity
            // 
            this.lblOutdoorHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblOutdoorHumidity.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.lblOutdoorHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblOutdoorHumidity.Location = new System.Drawing.Point(384, 618);
            this.lblOutdoorHumidity.Name = "lblOutdoorHumidity";
            this.lblOutdoorHumidity.Size = new System.Drawing.Size(153, 61);
            this.lblOutdoorHumidity.TabIndex = 6;
            this.lblOutdoorHumidity.Text = "25.60";
            this.lblOutdoorHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIndoorHumidity
            // 
            this.lblIndoorHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblIndoorHumidity.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.lblIndoorHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblIndoorHumidity.Location = new System.Drawing.Point(384, 556);
            this.lblIndoorHumidity.Name = "lblIndoorHumidity";
            this.lblIndoorHumidity.Size = new System.Drawing.Size(153, 61);
            this.lblIndoorHumidity.TabIndex = 5;
            this.lblIndoorHumidity.Text = "25.60";
            this.lblIndoorHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRainfallInmm
            // 
            this.lblRainfallInmm.BackColor = System.Drawing.Color.Transparent;
            this.lblRainfallInmm.Font = new System.Drawing.Font("Univers Condensed", 45F, System.Drawing.FontStyle.Bold);
            this.lblRainfallInmm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblRainfallInmm.Location = new System.Drawing.Point(774, 208);
            this.lblRainfallInmm.Name = "lblRainfallInmm";
            this.lblRainfallInmm.Size = new System.Drawing.Size(180, 81);
            this.lblRainfallInmm.TabIndex = 3;
            this.lblRainfallInmm.Text = "0.346";
            this.lblRainfallInmm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Univers Condensed", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(849, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 45);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "mm";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOutdoorTemp
            // 
            this.lblOutdoorTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblOutdoorTemp.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.lblOutdoorTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblOutdoorTemp.Location = new System.Drawing.Point(384, 318);
            this.lblOutdoorTemp.Name = "lblOutdoorTemp";
            this.lblOutdoorTemp.Size = new System.Drawing.Size(142, 61);
            this.lblOutdoorTemp.TabIndex = 2;
            this.lblOutdoorTemp.Text = "25.6";
            this.lblOutdoorTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIndoorTemp
            // 
            this.lblIndoorTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblIndoorTemp.Font = new System.Drawing.Font("Univers Condensed", 40F, System.Drawing.FontStyle.Bold);
            this.lblIndoorTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(196)))), ((int)(((byte)(246)))));
            this.lblIndoorTemp.Location = new System.Drawing.Point(384, 243);
            this.lblIndoorTemp.Name = "lblIndoorTemp";
            this.lblIndoorTemp.Size = new System.Drawing.Size(142, 61);
            this.lblIndoorTemp.TabIndex = 1;
            this.lblIndoorTemp.Text = "25.6";
            this.lblIndoorTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeatherStationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherStationMainForm";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxWindDirection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDrgCntrl;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndoorTemp;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOutdoorTemp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRainfallInmm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOutdoorHumidity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndoorHumidity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWindSpeed;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.PictureBox picBxWindDirection;
        private System.Windows.Forms.LinkLabel linkLblClose;
    }
}

