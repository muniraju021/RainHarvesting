using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStation.UI.AppCode;

namespace WeatherStation.UI
{
    public partial class WeatherStationMainForm : Form
    {
        private string _fileWatcherPath = string.Empty;
        private string _archivePath = string.Empty;
        FileSystemWatcher _fileWatcher = null;
        
        private readonly ILog _logger = LogManager.GetLogger(typeof(WeatherStationMainForm));
        delegate void _delUpdateControls(WeatherDetails objWeatherDetails);

        private string _previousRecordedRainfallData = "0";
        private DateTime _previousRecordedRainfallTime = DateTime.Now;

        public WeatherStationMainForm()
        {
            InitializeComponent();
            _fileWatcherPath = ConfigurationManager.AppSettings["FileWatcherPath"];
            _archivePath = ConfigurationManager.AppSettings["WeatherDetailsArchivePath"];
                        
            _fileWatcher = new FileSystemWatcher(_fileWatcherPath,"*.CSV");
            _fileWatcher.Created += _fileWatcher_Created;
            LoadLatestFileDetails();
            _fileWatcher.EnableRaisingEvents = true;

            _logger.InfoFormat($"File Watcher started at path {_fileWatcherPath}");
                        
        }

        private void LoadLatestFileDetails()
        {
            try
            {
                var direcInfo = new DirectoryInfo(_archivePath);
                var files = direcInfo.GetFiles().ToList();
                var latestFile = files.OrderByDescending(f => f.LastWriteTime).First();
                _logger.InfoFormat($"Loading Latest File Data - {latestFile.Name}");
                OnFileReceived(latestFile.FullName);
                _logger.InfoFormat($"Loaded Latest File Data - {latestFile.Name}");
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat($"Error in LoadLatestFileDetails - {ex.Message} {ex.StackTrace}");
            }
        }

        private void _fileWatcher_Created(object sender, FileSystemEventArgs e)
        {            
            bool isFileReady = false;
            while (!isFileReady)
            {
                try
                {
                    using (var stream = File.Open(e.FullPath, FileMode.Open, FileAccess.Read))
                    {
                        isFileReady = true;
                    }
                }
                catch (Exception ex)
                {
                    _logger.ErrorFormat($"File still copying... {ex.Message}");
                }
                Thread.Sleep(2000);
            }            
            
            OnFileReceived(e.FullPath);
        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        public void OnFileReceived(string filePath)
        {
            try
            {
                _logger.InfoFormat($"File received: {Path.GetFileName(filePath)}");

                var objWeatherStnMgmt = new WeatherStationManagement();
                var objWeatherDetails =  objWeatherStnMgmt.ProcessWeatherStationDetails(filePath);

                if(objWeatherDetails != null)
                {
                    LoadControlValues(objWeatherDetails,UpdateControls);
                    LoadControlValues(objWeatherDetails, ResetRainfallData);
                }
                else
                {
                    MessageBox.Show("Error in Processing Weather Details..! ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                _logger.InfoFormat($"File Processed: {Path.GetFileName(filePath)}");

                File.Move(filePath, Path.Combine(_archivePath + Path.GetFileName(filePath)));

                _logger.InfoFormat($"File Moved: {Path.Combine(_archivePath + Path.GetFileName(filePath))}");
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat($"Error in OnFileReceived - {ex.Message} {ex.StackTrace}");
            }
        }

        public void UpdateControls(WeatherDetails objWeatherDetails)
        {
            lblIndoorTemp.Text = objWeatherDetails.IndoorTemperature;
            lblIndoorHumidity.Text = objWeatherDetails.IndoorHumidity;
            lblOutdoorTemp.Text = objWeatherDetails.OutDoorTemp;
            lblOutdoorHumidity.Text = objWeatherDetails.OutDoorHumidity;
            lblRainfallInmm.Text = objWeatherDetails.Rainfall;
            lblWindSpeed.Text = objWeatherDetails.WindSpeed;

            Bitmap img = null;
            picBxWindDirection.Image = null;
            int winDirectionCorrected = 360;
            var windDirectionInt = Math.Round(Convert.ToDecimal(objWeatherDetails.WindDirection));
            winDirectionCorrected = (int)windDirectionInt;
            if (windDirectionInt > 0 && windDirectionInt < 45)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 45;
                else
                    winDirectionCorrected = 0;
            }
            else if (windDirectionInt > 45 && windDirectionInt < 90)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 90;
                else
                    winDirectionCorrected = 45;
            }
            else if (windDirectionInt > 90 && windDirectionInt < 135)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 135;
                else
                    winDirectionCorrected = 90;
            }
            else if (windDirectionInt > 135 && windDirectionInt < 180)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 180;
                else
                    winDirectionCorrected = 135;
            }
            else if (windDirectionInt > 180 && windDirectionInt < 225)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 225;
                else
                    winDirectionCorrected = 180;
            }
            else if (windDirectionInt > 225 && windDirectionInt < 270)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 270;
                else
                    winDirectionCorrected = 225;
            }
            else if (windDirectionInt > 270 && windDirectionInt < 315)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 315;
                else
                    winDirectionCorrected = 270;
            }
            else if (windDirectionInt > 315 && windDirectionInt < 360)
            {
                if ((windDirectionInt % 90) / 22 >= 1)
                    winDirectionCorrected = 360;
                else
                    winDirectionCorrected = 315;
            }


            switch (winDirectionCorrected)
            {
                case 360:
                case 0:
                    img = new Bitmap(@".\Images\N.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 45:
                    img = new Bitmap(@".\Images\NE.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 90:
                    img = new Bitmap(@".\Images\E.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 135:
                    img = new Bitmap(@".\Images\SE.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 180:
                    img = new Bitmap(@".\Images\S.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 225:
                    img = new Bitmap(@".\Images\SW.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 270:
                    img = new Bitmap(@".\Images\W.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
                case 315:
                    img = new Bitmap(@".\Images\NW.png");
                    picBxWindDirection.Image = img;
                    picBxWindDirection.Refresh();
                    break;
            }
        }

        public void LoadControlValues(WeatherDetails objWeatherDetails,Action<WeatherDetails> UpdateControls)
        {
            try
            {
                if(_fileWatcher.EnableRaisingEvents)
                {
                    this.Invoke(new _delUpdateControls(UpdateControls), objWeatherDetails);
                }
                else
                {
                    UpdateControls(objWeatherDetails);
                }
                
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat($"Error in LoadControlValues - {ex.Message} {ex.StackTrace}");
            }
        }

        public void ResetRainfallData(WeatherDetails objWeatherDetails)
        {
            if (_previousRecordedRainfallData == objWeatherDetails.Rainfall && (DateTime.Now - _previousRecordedRainfallTime).TotalMinutes >= 2)
            {
                lblRainfallInmm.Text = "0";                
            }
            else if (_previousRecordedRainfallData != objWeatherDetails.Rainfall)
            {
                lblRainfallInmm.Text = objWeatherDetails.Rainfall;
                _previousRecordedRainfallData = objWeatherDetails.Rainfall;
                _previousRecordedRainfallTime = DateTime.Now;
            }
             
        }
            
    }
}
