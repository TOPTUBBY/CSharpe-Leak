////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: confirmDialog.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 7/10/2021 12:00:00 PM
//Last Modified On : 22/10/2021 18:09:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Leak
{
    public partial class confirmDialog : Form
    {
        public confirmDialog()
        {
            InitializeComponent();
        }

        static confirmDialog MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption)
        {
            MsgBox = new confirmDialog();
            MsgBox.lblConfirm.Text = Text;
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }

        private void pbY_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Application.Exit();
        }

        private void pbX_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
