using RainHarvest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainHarvest.UI
{
    public partial class CalculateRHCost : Form
    {
        private Dictionary<double, RainfallData> _dtRoofInSqm = new Dictionary<double, RainfallData>();
        private Dictionary<double, RainfallData> _dtRoofInSqft = new Dictionary<double, RainfallData>();
        private RainfallData _objSelectedValue = null;
        private bool isRainfallDataLoaded = false;
        
        public CalculateRHCost()
        {
            InitializeComponent();
            Initialize();
            
        }
        

        public void Initialize()
        {
            _dtRoofInSqm = CacheManager.RainfallDatabyRoofAreaInSqm;            
            drpDownPlotAreaSqm.Items = _dtRoofInSqm.Keys.ToList().Select(i => i.ToString())
                                        .ToList().ToArray();

            _dtRoofInSqft = CacheManager.RainfallDatabyRoofAreaInSqft;            
            drpDownPlotAreaSqft.Items = _dtRoofInSqft.Keys.ToList().Select(i => i.ToString())
            .ToList().ToArray();

            drpDownConsumerUsage.Items = CacheManager.ConsumerUsageOfWaterLst.ToList().Select(i => i.ToString()).ToArray();
                        
        }

        private void drpDownPlotAreaSqm_onItemSelected(object sender, EventArgs e)
        {
            var areaSqm = drpDownPlotAreaSqm.selectedValue;
            if(!string.IsNullOrWhiteSpace(areaSqm))
            {
                this._objSelectedValue = _dtRoofInSqft.Values.Where(i => i.RoofAreaInSqm == Convert.ToInt64(areaSqm)).FirstOrDefault();
                drpDownPlotAreaSqft.selectedIndex = drpDownPlotAreaSqft.Items.ToList().IndexOf(_objSelectedValue.RoofAreaInSqft.ToString());
            }
        }

        private void drpDownPlotAreaSqft_onItemSelected(object sender, EventArgs e)
        {
            var areaSqft = drpDownPlotAreaSqft.selectedValue;
            if (!string.IsNullOrWhiteSpace(areaSqft))
            {
                this._objSelectedValue = _dtRoofInSqm.Values.Where(i => i.RoofAreaInSqft == Convert.ToInt64(areaSqft)).FirstOrDefault();
                drpDownPlotAreaSqm.selectedIndex = drpDownPlotAreaSqm.Items.ToList().IndexOf(_objSelectedValue.RoofAreaInSqm.ToString());
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_objSelectedValue != null && drpDownConsumerUsage.selectedIndex != -1)
                {
                    CalculateService objCalService = new CalculateService();
                    _objSelectedValue.ConsumerWaterUsage = Convert.ToInt64(drpDownConsumerUsage.selectedValue);
                    _objSelectedValue = objCalService.ProcessRainfallData(_objSelectedValue);

                    //Graphics graphic = Graphics.FromImage(pictureBox1.Image);
                    //graphic.Clear(Color.White);

                    pictureBox1.Image = null;
                    pictureBox1.Update();
                    pictureBox1.Refresh();

                    PrintReceipt();
                    DisplayResult();
                    
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisplayResult()
        {
            Graphics graphics  = pictureBox1.CreateGraphics();
            Font font8Bold = new Font("Courier New", 10, FontStyle.Bold);
            Font font8Reg = new Font("Courier New", 10, FontStyle.Regular);
            float fontHeight8 = font8Reg.GetHeight() + 5;
            SolidBrush brush = new SolidBrush(Color.Black);

            float startXMiddle = -10;
            float startX = 10;
            float startY = 0;
            float offset = 0;
            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            StringFormat formatRight = new StringFormat(formatLeft);

            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatLeft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(350, 320);
            RectangleF layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
                        
            //graphics.DrawString("HMWSSB", font8Bold, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("HYDERABAD METROPOLITAN", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("WATER SUPPY & SEWAGE BOARD", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("Phone:+918026653666", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("RWH - IMPLEMENTATIONS, USAGE, SAVINGS", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("AND PAY BACK CALCULATIONS", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //offset += 15;
            //layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            //graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            //offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Cost Of RWH Implementation", font8Bold, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("-----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Site Measuring", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RoofAreaInSqm}sqm", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Tank {_objSelectedValue.RainWaterTankCapacity}lt", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.TankCost.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"RWH Filter", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfTankRwhFilter.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Piping and Labour", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfPipeingAndLabor.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Total", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RwhImplementaionCost.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("-----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Water Usage and Savings/Year", font8Bold, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("-----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Consumer Requirement", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.ConsumerWaterUsage}lt/day", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Roof top Rainwater", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RoofTopRainWaterPotential}lt/day", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("potential @85% coll eff", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Water Saved Kilo-liter", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.WaterSavedPerKilolt}Kl", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("HMWSSB Water Rate Per Kl", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfWaterPerKiloLt.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Savings by not using", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"{_objSelectedValue.SavingsCostPerYear.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("HMWSSB Water", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Savings by not using", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"-", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Tank Water", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Pay Back Period", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.PaybackPeriod}Years", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("-----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            offset += 10;
            layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            graphics.DrawString("Thank you.", font8Bold, brush, layout, formatCenter);

            graphics.Dispose();
           
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = "EPSON TM-T82II Receipt";
            printDialog.Document = printDocument;
            
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font8Bold = new Font("Courier New", 8,FontStyle.Bold);
            Font font8Reg = new Font("Courier New", 8, FontStyle.Regular);
            float fontHeight8 = font8Reg.GetHeight() + 5;
            SolidBrush brush = new SolidBrush(Color.Black);

            float startXMiddle = -10;
            float startX = 0;
            float startY = 0;
            float offset = 0;
            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            StringFormat formatRight = new StringFormat(formatLeft);

            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatLeft.Alignment = StringAlignment.Near;
                        
            SizeF layoutSize = new SizeF(280 , 300);

            RectangleF layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            graphics.DrawString("HMWSSB", font8Bold, brush, layout, formatCenter);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            graphics.DrawString("HYDERABAD METROPOLITAN", font8Reg, brush, layout, formatCenter);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            graphics.DrawString("WATER SUPPY & SEWAGE BOARD", font8Reg, brush, layout, formatCenter);
            offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("Phone:+918026653666", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("RWH - IMPLEMENTATIONS, USAGE, SAVINGS", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            //layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            //graphics.DrawString("AND PAY BACK CALCULATIONS", font8Reg, brush, layout, formatCenter);
            //offset += fontHeight8;

            offset += 15;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Cost Of RWH Implementation", font8Bold, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Site Measuring", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RoofAreaInSqm}sqm", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Tank {_objSelectedValue.RainWaterTankCapacity}lt", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.TankCost.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"RWH Filter", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfTankRwhFilter.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Piping and Labour", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfPipeingAndLabor.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"Total", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RwhImplementaionCost.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Water Usage and Savings/Year", font8Bold, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Consumer Requirement", font8Reg, brush, layout, formatLeft);            
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.ConsumerWaterUsage}lt/day", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Roof top Rainwater", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"{_objSelectedValue.RoofTopRainWaterPotential}lt/day", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("potential @85% coll eff", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Water Saved Kilo-liter", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.WaterSavedPerKilolt}Kl", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("HMWSSB Water Rate Per Kl", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{MathConstants.CostOfWaterPerKiloLt.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Savings by not using", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"{_objSelectedValue.SavingsCostPerYear.ToString("F")}", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("HMWSSB Water", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Savings by not using", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset + 8), layoutSize);
            graphics.DrawString($"-", font8Reg, brush, layout, formatRight);
            offset += fontHeight8 - 5;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Tank Water", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("Pay Back Period", font8Reg, brush, layout, formatLeft);
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString($"{_objSelectedValue.PaybackPeriod}Years", font8Reg, brush, layout, formatRight);
            offset += fontHeight8;

            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            graphics.DrawString("----------------------------------------", font8Reg, brush, layout, formatLeft);
            offset += fontHeight8;

            offset += 10;
            layout = new RectangleF(new PointF(startXMiddle, startY + offset), layoutSize);
            graphics.DrawString("Thank you.", font8Bold, brush, layout, formatCenter);
           
            graphics.Dispose();
        }
                
    }
}
