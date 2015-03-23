using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
using LeTien.Utils;
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
    public partial class FormViewBranch : Form
    {

        #region "Constructors"
        public FormViewBranch()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
           
        }

        public FormViewBranch(Branch branch)
        {
            InitializeComponent();

            txtMaChiNhanh.Text = branch.BranchID;            
            txtTenChiNhanh.Text = branch.BranchName;
            txtDiaChi.Text = branch.BranchAddress;
            txtSoDienThoai.Text = branch.PhoneNumber;

            btnThem.Enabled = false;
            txtMaChiNhanh.Enabled = false;
        }

        #endregion


        #region "Method"
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Branch update = uow.FindObject<Branch>(CriteriaOperator.Parse("BranchID = ?", txtMaChiNhanh.Text));
                if (update != null)
                {
                    update.BranchName = txtTenChiNhanh.Text;
                    update.BranchAddress = txtDiaChi.Text;
                    update.PhoneNumber = txtSoDienThoai.Text;
                    try
                    {
                        if (LaHopLe() == true)
                        {
                            update.Save();
                            uow.CommitChanges();
                            frmBranchList f = this.Tag as frmBranchList;
                            f.RefreshData();
                            XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật không thành công", "Có lỗi!");
                        }
                    }

                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Có lỗi!");
                    }
                }
            }
        } 

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {               
                Branch insert = new Branch(uow);
                insert.BranchID = txtMaChiNhanh.Text;
                insert.BranchName = txtTenChiNhanh.Text;
                insert.BranchAddress = txtDiaChi.Text;
                insert.PhoneNumber = txtSoDienThoai.Text;
                try
                {
                    if(LaHopLe() == true)
                    {
                        insert.Save();
                        uow.CommitChanges();
                        frmBranchList f = this.Tag as frmBranchList;
                        f.RefreshData();
                        XtraMessageBox.Show("Thêm thành công", "Đã lưu");
                        CleanForm();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công", "Có lỗi!");
                    }
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Có lỗi!");
                }               
            }
        }

        private bool LaHopLe()
        {
            if(txtMaChiNhanh.Text == string.Empty || txtTenChiNhanh.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
       
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                XtraMessageBox.Show("Số điện thoại phải là số", "Có lỗi!");                
            }
        }

        private void CleanForm()
        {
            txtMaChiNhanh.Text = string.Empty;
            txtTenChiNhanh.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

    }
        #endregion
}
        
    

