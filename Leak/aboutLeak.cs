////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: aboutLeak.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 7/10/2021 12:00:00 PM
//Last Modified On : 14/06/2022 12:30:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Leak
{
    public partial class aboutLeak : Form
    {
        public aboutLeak()
        {
            InitializeComponent();
        }

        static aboutLeak MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Caption)
        {
            MsgBox = new aboutLeak();
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void aboutPE_Load(object sender, System.EventArgs e)
        {
            //set version info
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.lblVersion.Text = "Version " + info.FileVersion;
        }
    }
}
