using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeTien.Object;
using LeTien.Screens.Employee;
using DevExpress.Xpo;
using LeTien.Screens;

using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace LeTien.Screens.Employee
{
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            EmployeeList_Control.UCMain_Add_Clicked += EmployeeList_Control_UCMain_Add_Clicked;
            EmployeeList_Control.UCMain_Refresh_Clicked += EmployeeList_Control_UCMain_Refresh_Clicked;
            EmployeeList_Control.UCMain_Print_Clicked += EmployeeList_Control_UCMain_Print_Clicked;
            EmployeeList_Control.UCMain_Edit_Clicked += EmployeeList_Control_UCMain_Edit_Clicked;
        }

        void EmployeeList_Control_UCMain_Edit_Clicked(object sender, EventArgs e)
        {

            if (bandedGridView1.FocusedRowHandle < 0) return;
            try
            {
                Object.Employee employee = (Object.Employee)bandedGridView1.GetRow(bandedGridView1.FocusedRowHandle);
                if (employee == null)
                {
                    MessageBox.Show("Chưa chọn nhân viên", "Thông báo lỗi");
                    return;
                }
                using (var uow = new UnitOfWork())
                {
                    //Object.Employee getRecords = new XPCollection<Object.Employee>(uow, CriteriaOperator.Parse("Oid = ?", employee_id)).FirstOrDefault();
                    Object.Employee getRecords = uow.GetObjectByKey<Object.Employee>(employee.Oid);
                    if (getRecords == null) return;
                    FormEmployeeDetail f = new FormEmployeeDetail(getRecords);
                    f.ShowDialog();

                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi không mong muốn sảy ra/n" + ex.ToString(), "Thông báo lỗi");
            }
        }

        void EmployeeList_Control_UCMain_Add_Clicked(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitFormMain));
            FormEmployeeDetail f = new FormEmployeeDetail();
            f.ShowDialog();
            //SplashScreenManager.CloseForm();
        }

        void EmployeeList_Control_UCMain_Refresh_Clicked(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            xpCollectionEmployee.Reload();
            //gridControl1.Refresh();
            SplashScreenManager.CloseForm();
        }
        void EmployeeList_Control_UCMain_Print_Clicked(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControl1.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            // Open the Preview window.
           // gridControl1.ShowPrintPreview();

            gridControl1.Print();
        }

        private void xpCollectionEmployee_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e)
        {
            if (e.CollectionChangedType == XPCollectionChangedType.AfterRemove)
                (sender as XPCollection).Session.Delete(e.ChangedObject);
        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (bandedGridView1.FocusedRowHandle < 0) return;
            DataRow dr = bandedGridView1.GetDataRow(bandedGridView1.FocusedRowHandle);
            if (dr == null) return;
        }

        

    }
}
