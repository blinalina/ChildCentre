using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCentre
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
          /*  Properties.Settings.Default.id = -1;
            Properties.Settings.Default.Save();*/
        }

        private void ExitBotton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = -1;
            Properties.Settings.Default.role = -1;
            Properties.Settings.Default.Save();
            Hide();
            Application.OpenForms["AuthorizationForm"].Show();
        }
    }
}
