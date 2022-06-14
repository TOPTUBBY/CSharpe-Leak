////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: calCsmo.cs
//FileType: Visual C# Source file
//Author : TOPTUBBY (AnonymouS)
//Created On : 7/10/2021 12:00:00 PM
//Last Modified On : 14/06/2022 12:30:00 PM
//Copy Rights : Delta Electronics Thailand PCL.
//Description : Class for defining database related functions
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Forms;

namespace Leak
{
    public partial class calCsmo : Form
    {
        public calCsmo()
        {
            InitializeComponent();
            mtbCalDate.Text = Properties.Settings.Default.csmoCalDate;
            mtbDueDate.Text = Properties.Settings.Default.csmoDueDate;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}
