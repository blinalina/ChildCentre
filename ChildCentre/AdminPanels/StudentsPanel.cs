using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCentre.AdminPanels
{
    public partial class StudentsPanel : UserControl
    {
        public StudentsPanel(List<string> items)
        {
            InitializeComponent();
            StudentsComboBox.DataSource = items;
        }
        public StudentsPanel()
        {
            InitializeComponent();
        }

    }
}
