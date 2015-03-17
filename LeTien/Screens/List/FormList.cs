using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.List
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void navBarItem_ChiNhanh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach(Control ctrl in PPanel_Content.Controls)
            {
                ctrl.Dispose();
            }
            PPanel_Content.Controls.Add(new UCList());
        }
    }
}
