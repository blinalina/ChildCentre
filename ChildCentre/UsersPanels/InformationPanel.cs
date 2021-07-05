using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChildCentre.UsersPanels;
using ChildCentre.Utility;
using ChildCentre.Utility.DB;


namespace ChildCentre.UsersPanels
{
    public partial class InformationPanel : UserControl
    {

        public InformationPanel()
        {
            InitializeComponent();
        }
        private void InformationPanel_Load(object sender, EventArgs e)
        {
            AccountModel user=DBClient.GetAccount(Properties.Settings.Default.id);
            NameLabel.Text =user.FullName ;
            PhoneLabel.Text =user.PhoneNumber ;
            EmailLabel.Text =user.Email ;
            BirthLabel.Text =user.DateOfBirth.ToString("dd.MM.yyyy");
        }
    }
}
