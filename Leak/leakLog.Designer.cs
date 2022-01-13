
namespace Leak
{
    partial class leak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leak));
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbLeak = new System.Windows.Forms.TextBox();
            this.tbDETUL = new System.Windows.Forms.TextBox();
            this.tbDETLL = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbTPUL = new System.Windows.Forms.TextBox();
            this.tbTPLL = new System.Windows.Forms.TextBox();
            this.tbCH = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.comPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.tbMeasMode = new System.Windows.Forms.TextBox();
            this.lblMeasMode = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.tbErrorCode = new System.Windows.Forms.TextBox();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbChkSum = new System.Windows.Forms.TextBox();
            this.lblChkSum = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFormat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.pbNormScr = new System.Windows.Forms.PictureBox();
            this.gbCsmo = new System.Windows.Forms.GroupBox();
            this.btnCalCsmo = new System.Windows.Forms.Button();
            this.tbScrSN = new System.Windows.Forms.TextBox();
            this.pbScrFail = new System.Windows.Forms.PictureBox();
            this.pbScrPass = new System.Windows.Forms.PictureBox();
            this.lblScrCH = new System.Windows.Forms.Label();
            this.lblScrResult = new System.Windows.Forms.Label();
            this.lblCH = new System.Windows.Forms.Label();
            this.gbTestInfo = new System.Windows.Forms.GroupBox();
            this.pbComplete = new System.Windows.Forms.PictureBox();
            this.pbReport = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.lblGuide3 = new System.Windows.Forms.Label();
            this.lblGuide2 = new System.Windows.Forms.Label();
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.lblGuide0 = new System.Windows.Forms.Label();
            this.tbTester = new System.Windows.Forms.TextBox();
            this.tbTestStep = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblTester = new System.Windows.Forms.Label();
            this.lblTestStep = new System.Windows.Forms.Label();
            this.lblSampleType = new System.Windows.Forms.Label();
            this.cbbProject = new System.Windows.Forms.ComboBox();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.cbbSampleType = new System.Windows.Forms.ComboBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configPort = new System.Windows.Forms.ToolStripMenuItem();
            this.configFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSpec = new System.Windows.Forms.ToolStripMenuItem();
            this.helpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslblErrorCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbDisConnect = new System.Windows.Forms.PictureBox();
            this.pbDelta = new System.Windows.Forms.PictureBox();
            this.pbConnect = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.ts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormScr)).BeginInit();
            this.gbCsmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrPass)).BeginInit();
            this.gbTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.ms.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.Black;
            this.tbID.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbID.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.Aqua;
            this.tbID.Location = new System.Drawing.Point(128, 386);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(126, 31);
            this.tbID.TabIndex = 0;
            this.tbID.TabStop = false;
            this.tbID.Text = "-";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbID.Visible = false;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Black;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbResult.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.Color.Aqua;
            this.tbResult.Location = new System.Drawing.Point(128, 460);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(126, 31);
            this.tbResult.TabIndex = 0;
            this.tbResult.TabStop = false;
            this.tbResult.Text = "-";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbResult.Visible = false;
            // 
            // tbLeak
            // 
            this.tbLeak.BackColor = System.Drawing.Color.Black;
            this.tbLeak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeak.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbLeak.Font = new System.Drawing.Font("DS-Digital", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeak.ForeColor = System.Drawing.Color.LightGray;
            this.tbLeak.Location = new System.Drawing.Point(148, 93);
            this.tbLeak.Name = "tbLeak";
            this.tbLeak.ReadOnly = true;
            this.tbLeak.Size = new System.Drawing.Size(431, 120);
            this.tbLeak.TabIndex = 0;
            this.tbLeak.TabStop = false;
            this.tbLeak.Text = "+0.000";
            this.tbLeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDETUL
            // 
            this.tbDETUL.BackColor = System.Drawing.Color.Black;
            this.tbDETUL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDETUL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDETUL.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDETUL.ForeColor = System.Drawing.Color.White;
            this.tbDETUL.Location = new System.Drawing.Point(589, 235);
            this.tbDETUL.Name = "tbDETUL";
            this.tbDETUL.ReadOnly = true;
            this.tbDETUL.Size = new System.Drawing.Size(155, 37);
            this.tbDETUL.TabIndex = 0;
            this.tbDETUL.TabStop = false;
            this.tbDETUL.Text = "+000.000";
            // 
            // tbDETLL
            // 
            this.tbDETLL.BackColor = System.Drawing.Color.Black;
            this.tbDETLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDETLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDETLL.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDETLL.ForeColor = System.Drawing.Color.White;
            this.tbDETLL.Location = new System.Drawing.Point(203, 235);
            this.tbDETLL.Name = "tbDETLL";
            this.tbDETLL.ReadOnly = true;
            this.tbDETLL.Size = new System.Drawing.Size(155, 37);
            this.tbDETLL.TabIndex = 0;
            this.tbDETLL.TabStop = false;
            this.tbDETLL.Text = "+000.000";
            // 
            // tbPressure
            // 
            this.tbPressure.BackColor = System.Drawing.Color.Black;
            this.tbPressure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPressure.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPressure.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPressure.ForeColor = System.Drawing.Color.White;
            this.tbPressure.Location = new System.Drawing.Point(321, 428);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.ReadOnly = true;
            this.tbPressure.Size = new System.Drawing.Size(157, 37);
            this.tbPressure.TabIndex = 0;
            this.tbPressure.TabStop = false;
            this.tbPressure.Text = "+000.000";
            this.tbPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTPUL
            // 
            this.tbTPUL.BackColor = System.Drawing.Color.Black;
            this.tbTPUL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTPUL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTPUL.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTPUL.ForeColor = System.Drawing.Color.White;
            this.tbTPUL.Location = new System.Drawing.Point(589, 284);
            this.tbTPUL.Name = "tbTPUL";
            this.tbTPUL.ReadOnly = true;
            this.tbTPUL.Size = new System.Drawing.Size(155, 37);
            this.tbTPUL.TabIndex = 0;
            this.tbTPUL.TabStop = false;
            this.tbTPUL.Text = "+000.000";
            // 
            // tbTPLL
            // 
            this.tbTPLL.BackColor = System.Drawing.Color.Black;
            this.tbTPLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTPLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTPLL.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTPLL.ForeColor = System.Drawing.Color.White;
            this.tbTPLL.Location = new System.Drawing.Point(203, 284);
            this.tbTPLL.Name = "tbTPLL";
            this.tbTPLL.ReadOnly = true;
            this.tbTPLL.Size = new System.Drawing.Size(155, 37);
            this.tbTPLL.TabIndex = 0;
            this.tbTPLL.TabStop = false;
            this.tbTPLL.Text = "+000.000";
            // 
            // tbCH
            // 
            this.tbCH.BackColor = System.Drawing.Color.Black;
            this.tbCH.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCH.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCH.ForeColor = System.Drawing.Color.Aqua;
            this.tbCH.Location = new System.Drawing.Point(128, 497);
            this.tbCH.Name = "tbCH";
            this.tbCH.ReadOnly = true;
            this.tbCH.Size = new System.Drawing.Size(126, 31);
            this.tbCH.TabIndex = 0;
            this.tbCH.TabStop = false;
            this.tbCH.Text = "-";
            this.tbCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCH.Visible = false;
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.Black;
            this.tbTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTime.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.ForeColor = System.Drawing.Color.Aqua;
            this.tbTime.Location = new System.Drawing.Point(128, 607);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(126, 31);
            this.tbTime.TabIndex = 0;
            this.tbTime.TabStop = false;
            this.tbTime.Text = "00:00:00";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTime.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblID.Location = new System.Drawing.Point(27, 390);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Tester ID :";
            this.lblID.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblResult.Location = new System.Drawing.Point(50, 464);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 24);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result :";
            this.lblResult.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.Location = new System.Drawing.Point(59, 611);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 24);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time :";
            this.lblTime.Visible = false;
            // 
            // comPort1
            // 
            this.comPort1.DtrEnable = true;
            this.comPort1.RtsEnable = true;
            this.comPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comPort1_DataReceived);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rtbIncoming.Location = new System.Drawing.Point(1014, 45);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.ReadOnly = true;
            this.rtbIncoming.Size = new System.Drawing.Size(111, 26);
            this.rtbIncoming.TabIndex = 2;
            this.rtbIncoming.TabStop = false;
            this.rtbIncoming.Text = "";
            // 
            // tbMeasMode
            // 
            this.tbMeasMode.BackColor = System.Drawing.Color.Black;
            this.tbMeasMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMeasMode.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeasMode.ForeColor = System.Drawing.Color.Aqua;
            this.tbMeasMode.Location = new System.Drawing.Point(128, 423);
            this.tbMeasMode.Name = "tbMeasMode";
            this.tbMeasMode.ReadOnly = true;
            this.tbMeasMode.Size = new System.Drawing.Size(126, 31);
            this.tbMeasMode.TabIndex = 0;
            this.tbMeasMode.TabStop = false;
            this.tbMeasMode.Text = "-";
            this.tbMeasMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMeasMode.Visible = false;
            // 
            // lblMeasMode
            // 
            this.lblMeasMode.AutoSize = true;
            this.lblMeasMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMeasMode.Location = new System.Drawing.Point(53, 427);
            this.lblMeasMode.Name = "lblMeasMode";
            this.lblMeasMode.Size = new System.Drawing.Size(69, 24);
            this.lblMeasMode.TabIndex = 1;
            this.lblMeasMode.Text = "Mode :";
            this.lblMeasMode.Visible = false;
            // 
            // tbK
            // 
            this.tbK.BackColor = System.Drawing.Color.Black;
            this.tbK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbK.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbK.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbK.ForeColor = System.Drawing.Color.White;
            this.tbK.Location = new System.Drawing.Point(247, 380);
            this.tbK.Name = "tbK";
            this.tbK.ReadOnly = true;
            this.tbK.Size = new System.Drawing.Size(155, 37);
            this.tbK.TabIndex = 0;
            this.tbK.TabStop = false;
            this.tbK.Text = "+000.000";
            this.tbK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbErrorCode
            // 
            this.tbErrorCode.BackColor = System.Drawing.Color.Black;
            this.tbErrorCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbErrorCode.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrorCode.ForeColor = System.Drawing.Color.Aqua;
            this.tbErrorCode.Location = new System.Drawing.Point(128, 534);
            this.tbErrorCode.Name = "tbErrorCode";
            this.tbErrorCode.ReadOnly = true;
            this.tbErrorCode.Size = new System.Drawing.Size(126, 31);
            this.tbErrorCode.TabIndex = 0;
            this.tbErrorCode.TabStop = false;
            this.tbErrorCode.Text = "-";
            this.tbErrorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbErrorCode.Visible = false;
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblErrorCode.Location = new System.Drawing.Point(9, 538);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(113, 24);
            this.lblErrorCode.TabIndex = 1;
            this.lblErrorCode.Text = "Error Code :";
            this.lblErrorCode.Visible = false;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.Black;
            this.tbDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDate.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.Aqua;
            this.tbDate.Location = new System.Drawing.Point(128, 570);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(126, 31);
            this.tbDate.TabIndex = 0;
            this.tbDate.TabStop = false;
            this.tbDate.Text = "2021-01-01";
            this.tbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDate.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(64, 574);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            this.lblDate.Visible = false;
            // 
            // tbChkSum
            // 
            this.tbChkSum.BackColor = System.Drawing.Color.Black;
            this.tbChkSum.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbChkSum.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChkSum.ForeColor = System.Drawing.Color.Aqua;
            this.tbChkSum.Location = new System.Drawing.Point(128, 644);
            this.tbChkSum.Name = "tbChkSum";
            this.tbChkSum.ReadOnly = true;
            this.tbChkSum.Size = new System.Drawing.Size(126, 31);
            this.tbChkSum.TabIndex = 0;
            this.tbChkSum.TabStop = false;
            this.tbChkSum.Text = "-";
            this.tbChkSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChkSum.Visible = false;
            // 
            // lblChkSum
            // 
            this.lblChkSum.AutoSize = true;
            this.lblChkSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblChkSum.Location = new System.Drawing.Point(12, 648);
            this.lblChkSum.Name = "lblChkSum";
            this.lblChkSum.Size = new System.Drawing.Size(110, 24);
            this.lblChkSum.TabIndex = 1;
            this.lblChkSum.Text = "Checksum :";
            this.lblChkSum.Visible = false;
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.toolStripSeparator1,
            this.tsbCapture,
            this.toolStripSeparator2,
            this.tsbFormat,
            this.toolStripSeparator3,
            this.tsbExit});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(69, 808);
            this.ts.TabIndex = 6;
            // 
            // tsbStart
            // 
            this.tsbStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbStart.Image = global::Leak.Properties.Resources.icons8_conflict_48;
            this.tsbStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(51, 67);
            this.tsbStart.Text = "Start";
            this.tsbStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStart.ToolTipText = "Click to start program.";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(51, 6);
            // 
            // tsbCapture
            // 
            this.tsbCapture.Enabled = false;
            this.tsbCapture.Image = global::Leak.Properties.Resources.icons8_screenshot_48;
            this.tsbCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCapture.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tsbCapture.Name = "tsbCapture";
            this.tsbCapture.Size = new System.Drawing.Size(51, 67);
            this.tsbCapture.Text = "Capture";
            this.tsbCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCapture.ToolTipText = "Capture leakage screen";
            this.tsbCapture.Click += new System.EventHandler(this.tsbCapture_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(51, 6);
            // 
            // tsbFormat
            // 
            this.tsbFormat.Image = global::Leak.Properties.Resources.icons8_project_management_48;
            this.tsbFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFormat.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tsbFormat.Name = "tsbFormat";
            this.tsbFormat.Size = new System.Drawing.Size(51, 67);
            this.tsbFormat.Text = "Format";
            this.tsbFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFormat.Click += new System.EventHandler(this.tsbFormat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(51, 6);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::Leak.Properties.Resources.icons8_shutdown_48;
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(51, 67);
            this.tsbExit.Text = "Exit";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.ToolTipText = "Exit program.";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // pbNormScr
            // 
            this.pbNormScr.ErrorImage = global::Leak.Properties.Resources.gui_normal;
            this.pbNormScr.Image = global::Leak.Properties.Resources.gui_normalv3;
            this.pbNormScr.InitialImage = global::Leak.Properties.Resources.gui_normal;
            this.pbNormScr.Location = new System.Drawing.Point(22, 33);
            this.pbNormScr.Name = "pbNormScr";
            this.pbNormScr.Size = new System.Drawing.Size(777, 715);
            this.pbNormScr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNormScr.TabIndex = 5;
            this.pbNormScr.TabStop = false;
            // 
            // gbCsmo
            // 
            this.gbCsmo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCsmo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCsmo.Controls.Add(this.btnCalCsmo);
            this.gbCsmo.Controls.Add(this.tbScrSN);
            this.gbCsmo.Controls.Add(this.pbScrFail);
            this.gbCsmo.Controls.Add(this.pbScrPass);
            this.gbCsmo.Controls.Add(this.lblScrCH);
            this.gbCsmo.Controls.Add(this.tbLeak);
            this.gbCsmo.Controls.Add(this.tbTPUL);
            this.gbCsmo.Controls.Add(this.tbDETUL);
            this.gbCsmo.Controls.Add(this.tbDETLL);
            this.gbCsmo.Controls.Add(this.tbTPLL);
            this.gbCsmo.Controls.Add(this.tbK);
            this.gbCsmo.Controls.Add(this.tbPressure);
            this.gbCsmo.Controls.Add(this.lblScrResult);
            this.gbCsmo.Controls.Add(this.pbNormScr);
            this.gbCsmo.Enabled = false;
            this.gbCsmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbCsmo.Location = new System.Drawing.Point(71, 30);
            this.gbCsmo.Name = "gbCsmo";
            this.gbCsmo.Size = new System.Drawing.Size(813, 760);
            this.gbCsmo.TabIndex = 8;
            this.gbCsmo.TabStop = false;
            this.gbCsmo.Text = "LEAKAGE (COSMO LS-R700)";
            // 
            // btnCalCsmo
            // 
            this.btnCalCsmo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalCsmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCalCsmo.Location = new System.Drawing.Point(726, 0);
            this.btnCalCsmo.Name = "btnCalCsmo";
            this.btnCalCsmo.Size = new System.Drawing.Size(75, 26);
            this.btnCalCsmo.TabIndex = 8;
            this.btnCalCsmo.TabStop = false;
            this.btnCalCsmo.Text = "Calibration";
            this.btnCalCsmo.UseVisualStyleBackColor = true;
            this.btnCalCsmo.Click += new System.EventHandler(this.btnCalCsmo_Click);
            // 
            // tbScrSN
            // 
            this.tbScrSN.AutoCompleteCustomSource.AddRange(new string[] {
            "220000001812280001",
            "220010002108260001",
            "220050002108160001",
            "220000002107260001",
            "DES202012080061900001",
            "292A01977RTA10780001"});
            this.tbScrSN.BackColor = System.Drawing.Color.Black;
            this.tbScrSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScrSN.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbScrSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScrSN.ForeColor = System.Drawing.Color.White;
            this.tbScrSN.Location = new System.Drawing.Point(171, 592);
            this.tbScrSN.MaxLength = 22;
            this.tbScrSN.Name = "tbScrSN";
            this.tbScrSN.Size = new System.Drawing.Size(476, 42);
            this.tbScrSN.TabIndex = 0;
            this.tbScrSN.TabStop = false;
            this.tbScrSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScrSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSN_KeyDown);
            // 
            // pbScrFail
            // 
            this.pbScrFail.BackColor = System.Drawing.Color.Black;
            this.pbScrFail.ErrorImage = global::Leak.Properties.Resources.icons8_close_window_dark_64;
            this.pbScrFail.Image = global::Leak.Properties.Resources.icons8_close_window_dark_64;
            this.pbScrFail.InitialImage = global::Leak.Properties.Resources.icons8_close_window_dark_64;
            this.pbScrFail.Location = new System.Drawing.Point(217, 657);
            this.pbScrFail.Name = "pbScrFail";
            this.pbScrFail.Size = new System.Drawing.Size(94, 82);
            this.pbScrFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScrFail.TabIndex = 8;
            this.pbScrFail.TabStop = false;
            // 
            // pbScrPass
            // 
            this.pbScrPass.BackColor = System.Drawing.Color.Black;
            this.pbScrPass.ErrorImage = global::Leak.Properties.Resources.icons8_close_window_dark_64;
            this.pbScrPass.Image = global::Leak.Properties.Resources.icons8_tick_box_dark_64;
            this.pbScrPass.InitialImage = global::Leak.Properties.Resources.icons8_close_window_dark_64;
            this.pbScrPass.Location = new System.Drawing.Point(507, 657);
            this.pbScrPass.Name = "pbScrPass";
            this.pbScrPass.Size = new System.Drawing.Size(94, 82);
            this.pbScrPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScrPass.TabIndex = 8;
            this.pbScrPass.TabStop = false;
            // 
            // lblScrCH
            // 
            this.lblScrCH.AutoSize = true;
            this.lblScrCH.BackColor = System.Drawing.Color.Black;
            this.lblScrCH.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrCH.ForeColor = System.Drawing.Color.Yellow;
            this.lblScrCH.Location = new System.Drawing.Point(24, 43);
            this.lblScrCH.Name = "lblScrCH";
            this.lblScrCH.Size = new System.Drawing.Size(287, 32);
            this.lblScrCH.TabIndex = 7;
            this.lblScrCH.Text = "CH#00 ----------";
            this.lblScrCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScrResult
            // 
            this.lblScrResult.AutoSize = true;
            this.lblScrResult.BackColor = System.Drawing.Color.Transparent;
            this.lblScrResult.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScrResult.Location = new System.Drawing.Point(34, 525);
            this.lblScrResult.Name = "lblScrResult";
            this.lblScrResult.Size = new System.Drawing.Size(0, 32);
            this.lblScrResult.TabIndex = 1;
            // 
            // lblCH
            // 
            this.lblCH.AutoSize = true;
            this.lblCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCH.Location = new System.Drawing.Point(65, 501);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(57, 24);
            this.lblCH.TabIndex = 1;
            this.lblCH.Text = "CH# :";
            this.lblCH.Visible = false;
            // 
            // gbTestInfo
            // 
            this.gbTestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTestInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTestInfo.Controls.Add(this.lblGuide3);
            this.gbTestInfo.Controls.Add(this.pbComplete);
            this.gbTestInfo.Controls.Add(this.lblGuide2);
            this.gbTestInfo.Controls.Add(this.pbReport);
            this.gbTestInfo.Controls.Add(this.pbStart);
            this.gbTestInfo.Controls.Add(this.lblGuide0);
            this.gbTestInfo.Controls.Add(this.tbTester);
            this.gbTestInfo.Controls.Add(this.tbTestStep);
            this.gbTestInfo.Controls.Add(this.lblProject);
            this.gbTestInfo.Controls.Add(this.lblMode);
            this.gbTestInfo.Controls.Add(this.lblTester);
            this.gbTestInfo.Controls.Add(this.lblTestStep);
            this.gbTestInfo.Controls.Add(this.lblSampleType);
            this.gbTestInfo.Controls.Add(this.cbbProject);
            this.gbTestInfo.Controls.Add(this.cbbMode);
            this.gbTestInfo.Controls.Add(this.cbbSampleType);
            this.gbTestInfo.Controls.Add(this.lblSN);
            this.gbTestInfo.Controls.Add(this.lblID);
            this.gbTestInfo.Controls.Add(this.tbMeasMode);
            this.gbTestInfo.Controls.Add(this.btnClear);
            this.gbTestInfo.Controls.Add(this.tbTime);
            this.gbTestInfo.Controls.Add(this.tbResult);
            this.gbTestInfo.Controls.Add(this.tbCH);
            this.gbTestInfo.Controls.Add(this.tbDate);
            this.gbTestInfo.Controls.Add(this.lblResult);
            this.gbTestInfo.Controls.Add(this.lblMeasMode);
            this.gbTestInfo.Controls.Add(this.lblCH);
            this.gbTestInfo.Controls.Add(this.lblTime);
            this.gbTestInfo.Controls.Add(this.tbErrorCode);
            this.gbTestInfo.Controls.Add(this.lblChkSum);
            this.gbTestInfo.Controls.Add(this.tbChkSum);
            this.gbTestInfo.Controls.Add(this.lblErrorCode);
            this.gbTestInfo.Controls.Add(this.lblDate);
            this.gbTestInfo.Controls.Add(this.tbSN);
            this.gbTestInfo.Controls.Add(this.tbID);
            this.gbTestInfo.Controls.Add(this.lblGuide1);
            this.gbTestInfo.Enabled = false;
            this.gbTestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbTestInfo.Location = new System.Drawing.Point(892, 30);
            this.gbTestInfo.Name = "gbTestInfo";
            this.gbTestInfo.Size = new System.Drawing.Size(266, 760);
            this.gbTestInfo.TabIndex = 8;
            this.gbTestInfo.TabStop = false;
            this.gbTestInfo.Text = "TEST INFORMATION";
            // 
            // pbComplete
            // 
            this.pbComplete.ErrorImage = global::Leak.Properties.Resources.icons8_task_completed_64;
            this.pbComplete.Image = global::Leak.Properties.Resources.icons8_task_completed_64;
            this.pbComplete.InitialImage = global::Leak.Properties.Resources.icons8_task_completed_64;
            this.pbComplete.Location = new System.Drawing.Point(96, 431);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(81, 82);
            this.pbComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComplete.TabIndex = 10;
            this.pbComplete.TabStop = false;
            this.pbComplete.Visible = false;
            // 
            // pbReport
            // 
            this.pbReport.ErrorImage = global::Leak.Properties.Resources.icons8_signing_a_document_64;
            this.pbReport.Image = global::Leak.Properties.Resources.icons8_signing_a_document_64;
            this.pbReport.InitialImage = global::Leak.Properties.Resources.icons8_signing_a_document_64;
            this.pbReport.Location = new System.Drawing.Point(13, 377);
            this.pbReport.Name = "pbReport";
            this.pbReport.Size = new System.Drawing.Size(44, 45);
            this.pbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReport.TabIndex = 10;
            this.pbReport.TabStop = false;
            this.pbReport.Visible = false;
            // 
            // pbStart
            // 
            this.pbStart.ErrorImage = global::Leak.Properties.Resources.icons8_start_64;
            this.pbStart.Image = global::Leak.Properties.Resources.icons8_start_64;
            this.pbStart.InitialImage = global::Leak.Properties.Resources.icons8_start_64;
            this.pbStart.Location = new System.Drawing.Point(68, 312);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(59, 44);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 9;
            this.pbStart.TabStop = false;
            this.pbStart.Visible = false;
            // 
            // lblGuide3
            // 
            this.lblGuide3.AutoSize = true;
            this.lblGuide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGuide3.ForeColor = System.Drawing.Color.Green;
            this.lblGuide3.Location = new System.Drawing.Point(75, 516);
            this.lblGuide3.Name = "lblGuide3";
            this.lblGuide3.Size = new System.Drawing.Size(122, 24);
            this.lblGuide3.TabIndex = 8;
            this.lblGuide3.Text = "COMPLETE";
            this.lblGuide3.Visible = false;
            // 
            // lblGuide2
            // 
            this.lblGuide2.AutoSize = true;
            this.lblGuide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGuide2.ForeColor = System.Drawing.Color.Orange;
            this.lblGuide2.Location = new System.Drawing.Point(60, 390);
            this.lblGuide2.Name = "lblGuide2";
            this.lblGuide2.Size = new System.Drawing.Size(200, 24);
            this.lblGuide2.TabIndex = 8;
            this.lblGuide2.Text = "Wait generating report.";
            this.lblGuide2.Visible = false;
            // 
            // lblGuide1
            // 
            this.lblGuide1.AutoSize = true;
            this.lblGuide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGuide1.ForeColor = System.Drawing.Color.Blue;
            this.lblGuide1.Location = new System.Drawing.Point(14, 329);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(250, 72);
            this.lblGuide1.TabIndex = 8;
            this.lblGuide1.Text = "Press             at the machine.\r\n        and wait Testing .....\r\n\r\n";
            this.lblGuide1.Visible = false;
            // 
            // lblGuide0
            // 
            this.lblGuide0.AutoSize = true;
            this.lblGuide0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGuide0.ForeColor = System.Drawing.Color.Blue;
            this.lblGuide0.Location = new System.Drawing.Point(50, 262);
            this.lblGuide0.Name = "lblGuide0";
            this.lblGuide0.Size = new System.Drawing.Size(183, 16);
            this.lblGuide0.TabIndex = 8;
            this.lblGuide0.Text = "Type SN then press \'ENTER\'";
            // 
            // tbTester
            // 
            this.tbTester.AutoCompleteCustomSource.AddRange(new string[] {
            "Chotiwat",
            "Jaray.P",
            "Natrunooch.Siri",
            "Nattaphol.Nijc",
            "Kitsalanun.Kits",
            "Mutita.Khwa",
            "Patiphan.Phak",
            "Atit.Fayh"});
            this.tbTester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbTester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTester.Location = new System.Drawing.Point(96, 168);
            this.tbTester.Name = "tbTester";
            this.tbTester.Size = new System.Drawing.Size(158, 26);
            this.tbTester.TabIndex = 5;
            this.tbTester.Text = "Patiphan.Phak";
            this.tbTester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTestStep
            // 
            this.tbTestStep.AutoCompleteCustomSource.AddRange(new string[] {
            "Pre-test",
            "Initial",
            "Before",
            "After",
            "Final"});
            this.tbTestStep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbTestStep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTestStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTestStep.Location = new System.Drawing.Point(139, 136);
            this.tbTestStep.Name = "tbTestStep";
            this.tbTestStep.Size = new System.Drawing.Size(115, 26);
            this.tbTestStep.TabIndex = 4;
            this.tbTestStep.Text = "Initial";
            this.tbTestStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblProject.Location = new System.Drawing.Point(55, 33);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(78, 24);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Project :";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMode.Location = new System.Drawing.Point(19, 67);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(114, 24);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "Leak mode :";
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTester.Location = new System.Drawing.Point(17, 168);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(73, 24);
            this.lblTester.TabIndex = 6;
            this.lblTester.Text = "Tester :";
            // 
            // lblTestStep
            // 
            this.lblTestStep.AutoSize = true;
            this.lblTestStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTestStep.Location = new System.Drawing.Point(34, 136);
            this.lblTestStep.Name = "lblTestStep";
            this.lblTestStep.Size = new System.Drawing.Size(99, 24);
            this.lblTestStep.TabIndex = 6;
            this.lblTestStep.Text = "Test Step :";
            // 
            // lblSampleType
            // 
            this.lblSampleType.AutoSize = true;
            this.lblSampleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSampleType.Location = new System.Drawing.Point(1, 102);
            this.lblSampleType.Name = "lblSampleType";
            this.lblSampleType.Size = new System.Drawing.Size(132, 24);
            this.lblSampleType.TabIndex = 6;
            this.lblSampleType.Text = "Sample Type :";
            // 
            // cbbProject
            // 
            this.cbbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbProject.FormattingEnabled = true;
            this.cbbProject.Items.AddRange(new object[] {
            "7.4kW_CCU_L",
            "7.4kW_CCU_S",
            "22kW_CCU_L",
            "OBC_9.6kW",
            "OBC_11kW",
            "NIS_7.4kW",
            "REN_5DH"});
            this.cbbProject.Location = new System.Drawing.Point(139, 33);
            this.cbbProject.Name = "cbbProject";
            this.cbbProject.Size = new System.Drawing.Size(115, 28);
            this.cbbProject.TabIndex = 7;
            // 
            // cbbMode
            // 
            this.cbbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "Cooling",
            "Electronic"});
            this.cbbMode.Location = new System.Drawing.Point(139, 67);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(115, 28);
            this.cbbMode.TabIndex = 2;
            // 
            // cbbSampleType
            // 
            this.cbbSampleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSampleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbSampleType.FormattingEnabled = true;
            this.cbbSampleType.Items.AddRange(new object[] {
            "DV",
            "PV"});
            this.cbbSampleType.Location = new System.Drawing.Point(139, 102);
            this.cbbSampleType.Name = "cbbSampleType";
            this.cbbSampleType.Size = new System.Drawing.Size(115, 28);
            this.cbbSampleType.TabIndex = 3;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSN.Location = new System.Drawing.Point(17, 206);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(191, 24);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "Enter Serial Number :";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(9, 689);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 59);
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbSN
            // 
            this.tbSN.AutoCompleteCustomSource.AddRange(new string[] {
            "220000001812280001",
            "220010002108260001",
            "220050002108160001",
            "220000002107260001",
            "DES202012080061900001",
            "292A01977RTA10780001"});
            this.tbSN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSN.BackColor = System.Drawing.SystemColors.Window;
            this.tbSN.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSN.Location = new System.Drawing.Point(21, 233);
            this.tbSN.MaxLength = 22;
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(233, 26);
            this.tbSN.TabIndex = 6;
            this.tbSN.Text = "22000000181228XXXX";
            this.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSN_KeyDown);
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.White;
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(69, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1100, 24);
            this.ms.TabIndex = 10;
            this.ms.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpen,
            this.fileExit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileOpen
            // 
            this.fileOpen.Image = global::Leak.Properties.Resources.icons8_open_folder_in_new_tab_32;
            this.fileOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(171, 38);
            this.fileOpen.Text = "Open...";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileExit
            // 
            this.fileExit.Image = global::Leak.Properties.Resources.icons8_shutdown_32;
            this.fileExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.fileExit.Size = new System.Drawing.Size(171, 38);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configPort,
            this.configFormat});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // configPort
            // 
            this.configPort.Image = global::Leak.Properties.Resources.icons8_internet_of_things_32;
            this.configPort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configPort.Name = "configPort";
            this.configPort.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.configPort.Size = new System.Drawing.Size(186, 38);
            this.configPort.Text = "Port";
            this.configPort.Click += new System.EventHandler(this.configPort_Click);
            // 
            // configFormat
            // 
            this.configFormat.Image = global::Leak.Properties.Resources.icons8_project_management_32;
            this.configFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configFormat.Name = "configFormat";
            this.configFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.configFormat.Size = new System.Drawing.Size(186, 38);
            this.configFormat.Text = "Format";
            this.configFormat.Click += new System.EventHandler(this.configFormat_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpSpec,
            this.helpInfo});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpSpec
            // 
            this.helpSpec.Image = global::Leak.Properties.Resources.icons8_about_32;
            this.helpSpec.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpSpec.Name = "helpSpec";
            this.helpSpec.Size = new System.Drawing.Size(241, 38);
            this.helpSpec.Text = "Specification";
            this.helpSpec.Click += new System.EventHandler(this.helpSpec_Click);
            // 
            // helpInfo
            // 
            this.helpInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpInfo.Name = "helpInfo";
            this.helpInfo.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.helpInfo.Size = new System.Drawing.Size(241, 38);
            this.helpInfo.Text = "About Leakage Logging";
            this.helpInfo.Click += new System.EventHandler(this.helpInfo_Click);
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblErrorCode});
            this.ss.Location = new System.Drawing.Point(69, 786);
            this.ss.Name = "ss";
            this.ss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ss.ShowItemToolTips = true;
            this.ss.Size = new System.Drawing.Size(1100, 22);
            this.ss.SizingGrip = false;
            this.ss.TabIndex = 12;
            // 
            // tsslblErrorCode
            // 
            this.tsslblErrorCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslblErrorCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsslblErrorCode.Name = "tsslblErrorCode";
            this.tsslblErrorCode.Size = new System.Drawing.Size(43, 17);
            this.tsslblErrorCode.Text = "Status";
            // 
            // pbDisConnect
            // 
            this.pbDisConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDisConnect.ErrorImage = global::Leak.Properties.Resources.icons8_disconnected_48;
            this.pbDisConnect.Image = global::Leak.Properties.Resources.icons8_disconnected_48;
            this.pbDisConnect.InitialImage = global::Leak.Properties.Resources.icons8_disconnected_48;
            this.pbDisConnect.Location = new System.Drawing.Point(9, 647);
            this.pbDisConnect.Name = "pbDisConnect";
            this.pbDisConnect.Size = new System.Drawing.Size(56, 58);
            this.pbDisConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisConnect.TabIndex = 13;
            this.pbDisConnect.TabStop = false;
            // 
            // pbDelta
            // 
            this.pbDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDelta.ErrorImage = global::Leak.Properties.Resources.delta;
            this.pbDelta.Image = global::Leak.Properties.Resources.delta;
            this.pbDelta.InitialImage = global::Leak.Properties.Resources.delta;
            this.pbDelta.Location = new System.Drawing.Point(9, 731);
            this.pbDelta.Name = "pbDelta";
            this.pbDelta.Size = new System.Drawing.Size(56, 47);
            this.pbDelta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelta.TabIndex = 13;
            this.pbDelta.TabStop = false;
            // 
            // pbConnect
            // 
            this.pbConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbConnect.ErrorImage = global::Leak.Properties.Resources.icons8_connected_48;
            this.pbConnect.Image = global::Leak.Properties.Resources.icons8_connected_48;
            this.pbConnect.InitialImage = global::Leak.Properties.Resources.icons8_connected_48;
            this.pbConnect.Location = new System.Drawing.Point(9, 647);
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(56, 58);
            this.pbConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConnect.TabIndex = 13;
            this.pbConnect.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx|CSV (Comma Delimited) (*.csv)|*.csv|Text files (*." +
    "txt)|*.txt|All files (*.*)|*.*";
            // 
            // leak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1169, 808);
            this.Controls.Add(this.pbDelta);
            this.Controls.Add(this.pbDisConnect);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.gbTestInfo);
            this.Controls.Add(this.gbCsmo);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.pbConnect);
            this.Controls.Add(this.ts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "leak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEAKAGE LOGGING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leak_FormClosing);
            this.Load += new System.EventHandler(this.leak_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormScr)).EndInit();
            this.gbCsmo.ResumeLayout(false);
            this.gbCsmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrPass)).EndInit();
            this.gbTestInfo.ResumeLayout(false);
            this.gbTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbResult;
        public System.Windows.Forms.TextBox tbLeak;
        public System.Windows.Forms.TextBox tbDETUL;
        public System.Windows.Forms.TextBox tbDETLL;
        public System.Windows.Forms.TextBox tbPressure;
        public System.Windows.Forms.TextBox tbTPUL;
        public System.Windows.Forms.TextBox tbTPLL;
        public System.Windows.Forms.TextBox tbCH;
        public System.Windows.Forms.TextBox tbTime;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblResult;
        public System.Windows.Forms.Label lblTime;
        public System.IO.Ports.SerialPort comPort1;
        public System.Windows.Forms.TextBox tbMeasMode;
        public System.Windows.Forms.Label lblMeasMode;
        public System.Windows.Forms.TextBox tbK;
        public System.Windows.Forms.TextBox tbErrorCode;
        public System.Windows.Forms.Label lblErrorCode;
        public System.Windows.Forms.TextBox tbDate;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.TextBox tbChkSum;
        public System.Windows.Forms.Label lblChkSum;
        public System.Windows.Forms.ToolStripButton tsbStart;
        public System.Windows.Forms.PictureBox pbNormScr;
        public System.Windows.Forms.GroupBox gbCsmo;
        public System.Windows.Forms.Label lblCH;
        public System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tsslblErrorCode;
        public System.Windows.Forms.Label lblScrResult;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.RichTextBox rtbIncoming;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbExit;
        public System.Windows.Forms.GroupBox gbTestInfo;
        public System.Windows.Forms.Label lblScrCH;
        public System.Windows.Forms.Label lblSN;
        public System.Windows.Forms.TextBox tbSN;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCapture;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbDisConnect;
        private System.Windows.Forms.PictureBox pbDelta;
        public System.Windows.Forms.PictureBox pbConnect;
        private System.Windows.Forms.PictureBox pbScrFail;
        private System.Windows.Forms.PictureBox pbScrPass;
        public System.Windows.Forms.TextBox tbScrSN;
        private System.Windows.Forms.Label lblSampleType;
        public System.Windows.Forms.ComboBox cbbSampleType;
        private System.Windows.Forms.Label lblTestStep;
        public System.Windows.Forms.TextBox tbTestStep;
        public System.Windows.Forms.TextBox tbTester;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblTester;
        public System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.Label lblProject;
        public System.Windows.Forms.ComboBox cbbProject;
        public System.Windows.Forms.Button btnCalCsmo;
        public System.Windows.Forms.OpenFileDialog openFile;
        public System.Windows.Forms.ToolStripMenuItem fileOpen;
        public System.Windows.Forms.ToolStripMenuItem configFormat;
        public System.Windows.Forms.ToolStripMenuItem fileExit;
        public System.Windows.Forms.ToolStripMenuItem helpInfo;
        public System.Windows.Forms.ToolStripMenuItem helpSpec;
        public System.Windows.Forms.ToolStripMenuItem configPort;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbFormat;
        private System.Windows.Forms.Label lblGuide0;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.Label lblGuide1;
        private System.Windows.Forms.Label lblGuide2;
        private System.Windows.Forms.PictureBox pbReport;
        private System.Windows.Forms.PictureBox pbComplete;
        private System.Windows.Forms.Label lblGuide3;
    }
}

