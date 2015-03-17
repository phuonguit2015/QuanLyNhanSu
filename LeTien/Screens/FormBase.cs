using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LeTien.Screens
{
    public partial class FormBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormBase()
        {
            InitializeComponent();
        }
        protected bool IsChanged
        {
            get { return (UOW.GetObjectsToSave().Count > 0 || UOW.GetObjectsToDelete().Count > 0); }
        }
    }
}