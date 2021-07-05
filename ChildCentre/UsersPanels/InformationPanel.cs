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
            string[] acc = DBClient.GetAccount(Logg.Value);

            AccRole.Value = acc[0];
            NameLabel.Text = acc[1];
            PhoneLabel.Text = acc[2];
            EmailLabel.Text = acc[3];

            //если не выйти из аккаунта, то он будет ругаца. надо сделать чтобы при открытии всего запускалась стартовая форма, а не последняя, в которой находились
            //BirthLabel.Text = acc[4].Substring(0, 10);
        }
    }
}
