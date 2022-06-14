////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: leaklog.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 7/10/2021 12:00:00 PM
//Last Modified On : 14/06/2022 12:30:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Leak
{
    public partial class leak : Form
    {
        IniFile ini = new IniFile(@"D:\Automotive_Software_DET5\LEAKLOG\database\config.ini");
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);
        string InputData = string.Empty;
        _Application app;
        _Workbook workBook;
        _Worksheet workSheet;
        string trimSN;
        string reportfileName;
        string picfileName;
        calCsmo calCsmo = new calCsmo();

        public leak()
        {
            InitializeComponent();
            comPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(comPort1_DataReceived);
        }
        private void leak_Load(object sender, EventArgs e)
        {
            tsslblErrorCode.Text = "Device not connected";
        }


        private void leak_FormClosing(object sender, FormClosingEventArgs e)
        {
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }

        /*====================================================================================================*/
        /*-------------------------------------------Tool Strip-----------------------------------------------*/
        private void fileOpen_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FilterIndex == 1)
                {
                    path = openFile.FileName;
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(path);
                    app.Visible = true;
                }
                else if (openFile.FilterIndex == 2)
                {
                    path = openFile.FileName;
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(path);
                    app.Visible = true;
                }
                else
                {
                    path = openFile.FileName;
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "LEAKAGE LOGGING");
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }

        private void configPort_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\LEAKLOG\database\config.ini");
        }

        private void configFormat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\LEAKLOG\format");
        }

        private void helpSpec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under preparing process.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void helpEqMan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\LEAKLOG\manual\LS-R700-941B1-G-EMan-150722.pdf");
        }

        private void helpLeakMan_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\LEAKLOG\manual\LEAKLOG_Manual.pdf");
            }
            catch
            {
                MessageBox.Show("Under preparing process.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpInfo_Click(object sender, EventArgs e)
        {
            aboutLeak.Show("About Leakage Logging");
        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            String _port1 = ini.IniReadValue("LEAK", "PORT");
            String _baud1 = ini.IniReadValue("LEAK", "BAUDRATE");

            if (tsbStart.Text == "Start")
            {
                pbConnect.Visible = true;
                pbDisConnect.Visible = false;
                tsbCapture.Enabled = true;
                gbCsmo.Enabled = true;
                gbTestInfo.Enabled = true;
                tsbStart.Image = new Bitmap(Leak.Properties.Resources.icons8_full_stop_48);
                tsbStart.Text = "Stop";
                tsslblErrorCode.Text = "Ready";
                rtbIncoming.Clear();
                try
                {
                    comPort1.PortName = _port1;
                    comPort1.BaudRate = int.Parse(_baud1);
                    comPort1.Open();
                    comPort1.RtsEnable = true;
                    comPort1.DtrEnable = true;
                }
                catch
                {
                    pbConnect.Visible = false;
                    pbDisConnect.Visible = true;
                    tsbCapture.Enabled = false;
                    gbCsmo.Enabled = false;
                    gbTestInfo.Enabled = false;
                    tsbStart.Text = "Start";
                    tsbStart.Image = new Bitmap(Leak.Properties.Resources.icons8_conflict_48);
                    tsslblErrorCode.Text = "Device not connected";
                }
            }
            else if (tsbStart.Text == "Stop")
            {
                pbConnect.Visible = false;
                pbDisConnect.Visible = true;
                tsbCapture.Enabled = false;
                gbCsmo.Enabled = false;
                gbTestInfo.Enabled = false;
                tsbStart.Image = new Bitmap(Leak.Properties.Resources.icons8_conflict_48);
                tsbStart.Text = "Start";
                tsslblErrorCode.Text = "Device not connected";
                try
                {
                    comPort1.RtsEnable = false;
                    comPort1.DtrEnable = false;
                    comPort1.Close();
                }
                catch
                {

                }
            }
        }

        private void tsbCapture_Click(object sender, EventArgs e)
        {
            capture();
        }

        private void tsbFormat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Automotive_Software_DET5\LEAKLOG\format");
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            confirmDialog.Show("Do you want to exit ?", "LEAKAGE LOGGING");
            comPort1.RtsEnable = false;
            comPort1.DtrEnable = false;
            comPort1.Close();
        }

        /*====================================================================================================*/
        /*-------------------------------------------Read Port------------------------------------------------*/
        private void comPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = comPort1.ReadExisting();
            if (InputData != string.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
            else
            {

            }
        }

        /*====================================================================================================*/
        /*-----------------------------------------Cosmo Screen-----------------------------------------------*/
        //Value to box
        private void SetText(string text)
        {
            string[] valueSplit;
            rtbIncoming.Text += text;
            if (rtbIncoming.Text.Length == 125)
            {
                valueSplit = rtbIncoming.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                tbID.Text = valueSplit[0].TrimStart('#');       //ID
                switch (valueSplit[1])                          //Mode
                {
                    case "00":
                        tbMeasMode.Text = Properties.Resources.Mode00;
                        break;
                    case "01":
                        tbMeasMode.Text = Properties.Resources.Mode01;
                        break;
                    case "02":
                        tbMeasMode.Text = Properties.Resources.Mode02;
                        break;
                    case "03":
                        tbMeasMode.Text = Properties.Resources.Mode03;
                        break;
                }
                switch (valueSplit[2])                          //Result
                {
                    case "1":
                        tbResult.Text = Properties.Resources.Result1;
                        pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_64);
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_failv3);
                        lblScrResult.Text = Properties.Resources.Result1;
                        lblScrResult.BackColor = Color.Red;
                        lblScrResult.ForeColor = Color.White;
                        break;
                    case "2":
                        pbScrPass.Image = new Bitmap(Properties.Resources.icons8_tick_box_64);
                        tbResult.Text = Properties.Resources.Result2;
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_passv3);
                        lblScrResult.Text = "Pass";
                        lblScrResult.BackColor = Color.Lime;
                        break;
                    case "4":
                        tbResult.Text = Properties.Resources.Result4;
                        pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_64);
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_failv3);
                        lblScrResult.Text = Properties.Resources.Result4;
                        lblScrResult.BackColor = Color.Red;
                        lblScrResult.ForeColor = Color.White;
                        break;
                    case "9":
                        tbResult.Text = Properties.Resources.Result9;
                        pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_64);
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_failv3);
                        lblScrResult.Text = Properties.Resources.Result9;
                        lblScrResult.BackColor = Color.Red;
                        lblScrResult.ForeColor = Color.White;
                        break;
                    case "C":
                        tbResult.Text = Properties.Resources.ResultC;
                        pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_64);
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_failv3);
                        lblScrResult.Text = Properties.Resources.ResultC;
                        lblScrResult.BackColor = Color.Red;
                        lblScrResult.ForeColor = Color.White;
                        break;
                    case "D":
                        tbResult.Text = Properties.Resources.ResultD;
                        pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_64);
                        pbNormScr.Image = new Bitmap(Leak.Properties.Resources.gui_failv3);
                        lblScrResult.Text = Properties.Resources.ResultD;
                        lblScrResult.BackColor = Color.Red;
                        lblScrResult.ForeColor = Color.White;
                        break;
                }
                tbLeak.Text = valueSplit[3];                    //Leak
                tbDETUL.Text = valueSplit[4];                   //DET UL
                tbDETLL.Text = valueSplit[5];                   //DET LL
                //tbCompVal.Text = valueSplit[6];                 //Comp value    
                tbPressure.Text = valueSplit[7];                //Pressure
                tbTPUL.Text = valueSplit[8];                    //TP UL
                tbTPLL.Text = valueSplit[9];                    //TP LL
                tbCH.Text = valueSplit[10];                     //CH
                switch (tbCH.Text)
                {
                    case "00":
                        lblScrCH.Text = Properties.Settings.Default.CH00;
                        break;
                    case "01":
                        lblScrCH.Text = Properties.Settings.Default.CH00;
                        break;
                    case "02":
                        lblScrCH.Text = Properties.Settings.Default.CH02;
                        break;
                    case "03":
                        lblScrCH.Text = Properties.Settings.Default.CH03;
                        break;
                    case "04":
                        lblScrCH.Text = Properties.Settings.Default.CH04;
                        break;
                    case "05":
                        lblScrCH.Text = Properties.Settings.Default.CH05;
                        break;
                    case "06":
                        lblScrCH.Text = Properties.Settings.Default.CH06;
                        break;
                    case "07":
                        lblScrCH.Text = Properties.Settings.Default.CH07;
                        break;
                    case "08":
                        lblScrCH.Text = Properties.Settings.Default.CH08;
                        break;
                    case "09":
                        lblScrCH.Text = Properties.Settings.Default.CH09;
                        break;
                    case "10":
                        lblScrCH.Text = Properties.Settings.Default.CH10;
                        break;
                    case "11":
                        lblScrCH.Text = Properties.Settings.Default.CH11;
                        break;
                    case "12":
                        lblScrCH.Text = Properties.Settings.Default.CH12;
                        break;
                    case "13":
                        lblScrCH.Text = Properties.Settings.Default.CH13;
                        break;
                    case "14":
                        lblScrCH.Text = Properties.Settings.Default.CH14;
                        break;
                    case "15":
                        lblScrCH.Text = Properties.Settings.Default.CH15;
                        break;
                    case "16":
                        lblScrCH.Text = Properties.Settings.Default.CH16;
                        break;
                    case "17":
                        lblScrCH.Text = Properties.Settings.Default.CH17;
                        break;
                    case "18":
                        lblScrCH.Text = Properties.Settings.Default.CH18;
                        break;
                    case "19":
                        lblScrCH.Text = Properties.Settings.Default.CH19;
                        break;
                    case "20":
                        lblScrCH.Text = Properties.Settings.Default.CH20;
                        break;
                    case "21":
                        lblScrCH.Text = Properties.Settings.Default.CH21;
                        break;
                    case "22":
                        lblScrCH.Text = Properties.Settings.Default.CH22;
                        break;
                    case "23":
                        lblScrCH.Text = Properties.Settings.Default.CH23;
                        break;
                    case "24":
                        lblScrCH.Text = Properties.Settings.Default.CH24;
                        break;
                    case "25":
                        lblScrCH.Text = Properties.Settings.Default.CH25;
                        break;
                    case "26":
                        lblScrCH.Text = Properties.Settings.Default.CH26;
                        break;
                    case "27":
                        lblScrCH.Text = Properties.Settings.Default.CH27;
                        break;
                    case "28":
                        lblScrCH.Text = Properties.Settings.Default.CH28;
                        break;
                    case "29":
                        lblScrCH.Text = Properties.Settings.Default.CH29;
                        break;
                    case "30":
                        lblScrCH.Text = Properties.Settings.Default.CH30;
                        break;
                    case "31":
                        lblScrCH.Text = Properties.Settings.Default.CH31;
                        break;
                }
                tbK.Text = valueSplit[12];                      //K(Ve)
                tbErrorCode.Text = valueSplit[14];              //Error Code
                switch (tbErrorCode.Text)
                {
                    case "4000":
                        tsslblErrorCode.Text = Properties.Resources.Code4000;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0800":
                        tsslblErrorCode.Text = Properties.Resources.Code0800;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0400":
                        tsslblErrorCode.Text = Properties.Resources.Code0400;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0200":
                        tsslblErrorCode.Text = Properties.Resources.Code0200;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0100":
                        tsslblErrorCode.Text = Properties.Resources.Code0100;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0080":
                        tsslblErrorCode.Text = Properties.Resources.Code0080;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0020":
                        tsslblErrorCode.Text = Properties.Resources.Code0020;
                        tsslblErrorCode.ForeColor = Color.Red;
                        break;
                    case "0000":
                        tsslblErrorCode.Text = Properties.Resources.Code0000;
                        tsslblErrorCode.ForeColor = Color.DarkGreen;
                        break;
                }
                tbDate.Text = valueSplit[15];                   //Date
                tbTime.Text = valueSplit[16];                   //Time
                tbChkSum.Text = valueSplit[17].TrimStart(':');  //Checksum
                tbScrSN.Text = tbSN.Text;
                try
                {
                    trimSN = tbSN.Text.Substring(tbSN.Text.Length - 6);
                }
                catch
                {

                }
                lblGuide1.Visible = false;
                pbStart.Visible = false;
                MessageBox.Show("Capture", "LEAKAGE LOGGING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbReport.Visible = true;
                lblGuide2.Visible = true;
                Thread.Sleep(1000);
                capture();

                try
                {
                    reportfileName = "LEAK_" + cbbProject.SelectedItem + "_" + tbSN.Text;
                    string formatPath = @"D:\Automotive_Software_DET5\LEAKLOG\format\" + cbbProject.SelectedItem + ".xlsx";
                    string dataPath = @"D:\LEAK_DATA\" + reportfileName + ".xlsx";
                    if (!File.Exists(dataPath))
                    {
                        System.IO.File.Copy(formatPath, dataPath);
                    }
                    app = new Microsoft.Office.Interop.Excel.Application();
                    workBook = app.Workbooks.Open(dataPath);
                    workSheet = app.Worksheets[cbbMode.SelectedItem];                           //Leak mode
                    workSheet.Cells[6, 37].Value = cbbSampleType.SelectedItem;                  //Sample type
                    workSheet.Cells[8, 10].Value = tbTestStep.Text;                             //Test step
                    workSheet.Cells[7, 37].Value = tbTester.Text;                               //Tester name
                    workSheet.Cells[8, 37].Value = System.DateTime.Now.ToString("MM-dd-yyyy");  //Test date
                    //workSheet.Cells[13, 33].Value = Properties.Settings.Default.csmoDueDate;
                    workSheet.Cells[35, 8].Value = lblScrCH.Text;                               //Channel
                    workSheet.Cells[39, 2].Value = "'" + tbScrSN.Text;                          //SN
                    workSheet.Shapes.AddPicture(@"D:\LEAK_DATA\" + picfileName + ".jpeg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 596, 155, 147);
                    workBook.Close(true, Type.Missing, Type.Missing);
                    app.Quit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                lblGuide2.Visible = false;
                pbReport.Visible = false;
                lblGuide3.Visible = true;
                pbComplete.Visible = true;
                tsslblErrorCode.Text = "Report generate done";
                MessageBox.Show("Report has been created.", "LEAKAGE LOGGING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalCsmo_Click(object sender, EventArgs e)
        {
            calCsmo.ShowDialog();
            Properties.Settings.Default.csmoCalDate = calCsmo.mtbCalDate.Text;
            Properties.Settings.Default.csmoDueDate = calCsmo.mtbDueDate.Text;
            Properties.Settings.Default.Save();
        }

        /*====================================================================================================*/
        /*-----------------------------------------Test information-------------------------------------------*/
        private void tbSN_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbSN.BackColor = Color.GreenYellow;
                    lblGuide0.Visible = false;
                    lblGuide1.Visible = true;
                    pbStart.Visible = true;
                }
            }
            catch
            {

            }
        }

        //Clear all
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblGuide3.Visible = false;
            pbComplete.Visible = false;
            lblGuide0.Visible = true;
            lblGuide1.Visible = false;
            pbStart.Visible = false;
            rtbIncoming.Clear();
            pbNormScr.Image = new Bitmap(Properties.Resources.gui_normalv3);
            lblScrResult.Text = "";
            lblScrResult.BackColor = Color.Transparent;
            lblScrResult.ForeColor = Color.Black;
            tbScrSN.Text = "";
            pbScrPass.Image = new Bitmap(Properties.Resources.icons8_tick_box_dark_64);
            pbScrFail.Image = new Bitmap(Properties.Resources.icons8_close_window_dark_64);
            //tbSN.Text = "";
            tbSN.BackColor = Color.White;
            tbID.Text = Properties.Settings.Default.defaultText;
            tbMeasMode.Text = Properties.Settings.Default.defaultText;
            tbResult.Text = Properties.Settings.Default.defaultText;
            tbCH.Text = Properties.Settings.Default.defaultText;
            tbErrorCode.Text = Properties.Settings.Default.defaultText;
            tbChkSum.Text = Properties.Settings.Default.defaultText;
            tsslblErrorCode.Text = "Ready";
        }

        /*====================================================================================================*/
        /*------------------------------------Capture Cosmo Screen--------------------------------------------*/
        private void capture()
        {
            Bitmap cosmoScr = new Bitmap(pbNormScr.Width, pbNormScr.Height);
            Graphics graphics = Graphics.FromImage(cosmoScr);
            System.Drawing.Rectangle rect = pbNormScr.RectangleToScreen(pbNormScr.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, System.Drawing.Point.Empty, pbNormScr.Size);
            string root = @"D:\LEAK_DATA";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            picfileName = cbbMode.SelectedItem + "_" + cbbProject.SelectedItem + "_" + trimSN + "_" + System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            cosmoScr.Save(@"D:\LEAK_DATA\" + picfileName + ".jpeg");
        }
    }

    /*====================================================================================================*/
    /*-----------------------------------------Class Ext.Config-------------------------------------------*/
    class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }

    }
}
