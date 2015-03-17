using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using LeTien.Object;
using LeTien.Screens;
using DevExpress.Utils;

namespace LeTien.Screens
{
    public partial class FrmAttendance : DevExpress.XtraEditors.XtraForm
    {
        public int attendanceMonth;

        public int attendanceYear;

        public string dateVN(string enDate)
        {
            string strReturn;

            switch (enDate)
            {
                case "Monday":
                    strReturn = "THai";
                    break;
                case "Tuesday":
                    strReturn = "TBa";
                    break;
                case "Wednesday":
                    strReturn = "TTư";
                    break;
                case "Thursday":
                    strReturn = "TNăm";
                    break;
                case "Friday":
                    strReturn = "TSáu";
                    break;
                case "Saturday":
                    strReturn = "TBảy";
                    break;
                case "Sunday":
                default: 
                    strReturn = "CN";
                    break;
            }

            return strReturn;
        }


        public FrmAttendance(string attendanceMonth = null, string attendanceYear = null)
        {
            InitializeComponent();
            this.renderAttendanDateceColumn();
            this.renderAttendanceSymbol();
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DateOfMonth")
            {
                GridView currentView = sender as GridView;
                string employeeID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                //int date = int.Parse(e.Column.Caption.ToString());
                int date = e.Column.VisibleIndex - 1;

                string attendanceDate = this.attendanceYear.ToString() + "-" + (this.attendanceMonth < 10 ? "0" + this.attendanceMonth.ToString() : this.attendanceMonth.ToString()) + "-" + (date < 10 ? "0" + date.ToString() : date.ToString());

                int attendanceColor = Object.Attendance.GetAttendanceSymbolColorEmployeeByDate(employeeID, attendanceDate, session1);
                if (attendanceColor != 0)
                {
                    e.Appearance.BackColor = System.Drawing.Color.FromArgb(attendanceColor); 
                    e.DisplayText = Object.Attendance.GetAttendanceSymbolKeyEmployeeByDate(employeeID, attendanceDate, session1);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            this.attendanceMonth = dateTimePicker1.Value.Month;
            this.attendanceYear = dateTimePicker1.Value.Year;

            this.removeAttendanceDateColumn();
            System.Threading.Thread.Sleep(2000);
            this.renderAttendanDateceColumn();
            SplashScreenManager.CloseForm();

        }

        public void renderAttendanDateceColumn()
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (this.attendanceMonth == 0 || this.attendanceYear == 0)
            {
                
                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                this.attendanceMonth = now.Month;
                this.attendanceYear = now.Year;
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(this.attendanceYear, this.attendanceMonth);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                int indx = i;
                // Create an unbound column.
                var unbColumn = new GridColumn();
                DateTime curDate = new DateTime(this.attendanceYear, this.attendanceMonth, indx);

                unbColumn.Caption = indx.ToString() + " (" + dateVN(curDate.DayOfWeek.ToString()) + ")";
                //unbColumn.Caption = indx.ToString();
                unbColumn.VisibleIndex = gridView1.Columns.Count;

                unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

                // Disable editing.
                unbColumn.OptionsColumn.AllowEdit = false;
                // Specify format settings.
                unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                unbColumn.DisplayFormat.FormatString = "c";
                unbColumn.Name = "DateOfMonth";
                // Customize the appearance settings

                unbColumn.AppearanceHeader.Options.UseTextOptions = true;
                unbColumn.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                unbColumn.AppearanceCell.Options.UseTextOptions = true;
                unbColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                if (i == now.Day && ((this.attendanceMonth == now.Month && this.attendanceYear == now.Year) || (this.attendanceMonth == 0 && this.attendanceYear == 0)))
                {
                    gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
                    unbColumn.AppearanceHeader.Font = new Font(unbColumn.AppearanceHeader.Font, FontStyle.Bold);
                    unbColumn.AppearanceHeader.ForeColor = System.Drawing.Color.OrangeRed;
                    unbColumn.AppearanceHeader.Options.UseFont = true;
                    unbColumn.AppearanceHeader.Options.UseForeColor = true;
                }
                gridView1.Columns.Insert(gridView1.Columns.Count, unbColumn);
            }
        }
        public void removeAttendanceDateColumn()
        {
            while (gridView1.Columns.Count > 4)
            {
                gridView1.Columns.Remove(gridView1.Columns[4]);
            }
        }

        public void renderAttendanceSymbol()
        {
            layoutControl1.BeginUpdate();

            DevExpress.Xpo.DB.SelectedData resAttendanceSymbols = Object.AttendanceSymbol.GetAllAttendanceSymbols(session1);

            if (resAttendanceSymbols.ResultSet[0].Rows.Length > 0)
            {
                for (int i = 0; i < resAttendanceSymbols.ResultSet[0].Rows.Length; i++)
                {
                    int symbolColor = int.Parse(resAttendanceSymbols.ResultSet[0].Rows[i].Values[3].ToString());

                    LayoutControlItem newItem = new LayoutControlItem();

                    newItem.Control = new LabelControl();

                    newItem.Control.BackColor = System.Drawing.Color.FromArgb(symbolColor);
                    newItem.Control.Text = resAttendanceSymbols.ResultSet[0].Rows[i].Values[1].ToString();
                    Size newSize = new Size(105, 41);
                    newItem.MaxSize = newSize;
                    newItem.MinSize = newSize;
                    layoutControlGroup2.AddItem(newItem);
                }
            }

            


            layoutControl1.EndUpdate();
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.Name == "DateOfMonth")
            {
                GridView currentView = sender as GridView;
                string employeeID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                string employeeFName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["first_name"]).ToString();
                string employeeLName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["last_name"]).ToString();
                string employeeIDText = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["employee_id"]).ToString();
                //int date = int.Parse(e.Column.Caption.ToString());
                int date = e.Column.VisibleIndex - 1;
                
                string attendanceDate = this.attendanceYear.ToString() + "-" + (this.attendanceMonth < 10 ? "0" + this.attendanceMonth.ToString() : this.attendanceMonth.ToString()) + "-" + (date < 10 ? "0" + date.ToString() : date.ToString());
                string attendanceID = Object.Attendance.GetAttendanceIdOfEmployeeByDate(employeeID, attendanceDate, session1);

                //Call form input attendance
                string frmCaption = "Chấm công nhân viên - " + employeeLName + " " + employeeLName + " (" + employeeIDText + ") ngày " + attendanceDate;
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                FrmPutAttendance frm = new FrmPutAttendance();
                System.Threading.Thread.Sleep(2000);
                frm.Text = frmCaption;
                frm.Show();
                SplashScreenManager.CloseForm();

            }   
        }
    }
}
