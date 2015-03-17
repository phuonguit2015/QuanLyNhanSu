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
using LeTien.Object;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.IO;
namespace LeTien.Screens.Employee
{
    public partial class FormEmployeeDetail : LeTien.Screens.FormBase
    {
      
        Object.Employee employee;
        ErrorProvider err = new ErrorProvider();
        bool save_status = true;
        public FormEmployeeDetail()
        {
            InitializeComponent();
            employee = new Object.Employee();
            binding_combobox_data();
            reset_form();
            binding_data();
            init_menu("new");

        }
        public FormEmployeeDetail(Object.Employee init_employee)
        {
            InitializeComponent();
            UOW = init_employee.Session as UnitOfWork;
            employee = init_employee;
            binding_combobox_data();
            //reset_form();
            binding_data();
            init_menu("update");
        }
        private void init_menu(string action)
        {
            if(action == "new")
            {
                BBar_SaveOnly.Visibility = BarItemVisibility.Never;
            }
            else
            {
                BButton_Save.Visibility = BarItemVisibility.Never;
            }
        }
        private void BButton_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (validate_form() == true)
            {
                try
                {
                    // SplashScreenManager.ShowForm(typeof(WaitSaving));
                    Save();
                    save_status = true;
                    reset_form();
                    binding_data();
                    // SplashScreenManager.CloseForm(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi không mong muốn sãy ra, không thể lưu dữ liệu\n\n" + ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //binding_data();
                    this.Close();
                }
            }
        }


        private void BButton_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void Save()
        {
            employee.Save();
            if (!IsChanged)
            {
                return;
            }
            try
            {
                UOW.CommitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TextEID_Validating(object sender, CancelEventArgs e)
        {
            //validate_form();
        }

        private void TextEID_Validated(object sender, EventArgs e)
        {
            //validate_form();
            
        }
        private bool validate_form()
        {
            err.Clear();
            bool flag = true;
            if (TextEID.Text == "")
            {
                flag = false;
                err.SetError(TextEID, "Chưa nhập mã nhân viên");
            }
            if (TextFistname.Text == "")
            {
                flag = false;
                err.SetError(TextFistname, "Chưa nhập tên nhân viên");
            }
            if (TextLastname.Text == "")
            {
                flag = false;
                err.SetError(TextLastname, "Chưa nhập họ lót nhân viên");
            }
            if (TextSalary.Text == "")
            {
                flag = false;
                err.SetError(TextSalary, "Chưa nhập lương cơ bản");
            }
            return flag;
        }
        void reset_form()
        {
            
            employee = new Object.Employee();
            TextEID.Text = "";
            TextFistname.Text = "";
            TextLastname.Text = "";
            SelectGender.SelectedIndex = 0;
            DateBirthday.DateTime = DateTime.Now;
            TextBirthPlace.Text = "";
            TextIdentifyNumber.Text = "";
            DateIdentifyDate.DateTime = DateTime.Now;
            TextIdentifyPlace.Text = "";
            TextAddress.Text = "";
            TextMobile.Text = "";
            TextPhone.Text = "";
            //SelectReligious.SelectedText;
            TextNationality.Text = "";
            TextEducated.Text = "";
            //SelectMarried.SelectedText;
            //SelectBranch.SelectedItem;
            //SelectPosition.SelectedItem;

            TextSalary.Value = 0;
            TextATM.Text = "";
            TextInsuranceNum.Text = "";
            DateInsuranceDate.DateTime = DateTime.Now;
            TextLaborContractID.Text = "";
            //SelectLaborContractType.SelectedIndex;
            DateLaborContractSign.DateTime = DateTime.Now;
            DateLaborContractFrom.DateTime = DateTime.Now;
            DateLaborContractTo.DateTime = DateTime.Now;
        }
        void binding_data()
        {
            TextEID.DataBindings.Clear();
            TextFistname.DataBindings.Clear();
            TextLastname.DataBindings.Clear();
            SelectGender.DataBindings.Clear();
            DateBirthday.DataBindings.Clear();
            TextBirthPlace.DataBindings.Clear();
            TextIdentifyNumber.DataBindings.Clear();
            DateIdentifyDate.DataBindings.Clear();
            TextIdentifyPlace.DataBindings.Clear();
            TextAddress.DataBindings.Clear();
            TextMobile.DataBindings.Clear();
            TextNationality.DataBindings.Clear();
            //SelectReligious.SelectedText;
            //SelectMarried.SelectedText;
            //SelectBranch.SelectedItem;
            //SelectPosition.SelectedItem;
            //SelectLaborContractType.SelectedIndex;
            TextSalary.DataBindings.Clear();
            TextATM.DataBindings.Clear();
            TextInsuranceNum.DataBindings.Clear();
            DateInsuranceDate.DataBindings.Clear();
            TextLaborContractID.DataBindings.Clear();
            
            TextEID.DataBindings.Add("EditValue", employee, "employee_id");
            TextFistname.DataBindings.Add("Text", employee, "first_name");
            TextLastname.DataBindings.Add("EditValue", employee, "last_name");
            SelectGender.DataBindings.Add("SelectedIndex", employee, "gender");
            DateBirthday.DataBindings.Add("EditValue", employee, "birthday");
            TextBirthPlace.DataBindings.Add("EditValue", employee, "birthplace");
            TextIdentifyNumber.DataBindings.Add("EditValue", employee, "identity_card_id");
            DateIdentifyDate.DataBindings.Add("EditValue", employee, "identity_card_date");
            TextIdentifyPlace.DataBindings.Add("EditValue", employee, "identity_card_place");
            TextAddress.DataBindings.Add("EditValue", employee, "permanent_address");
            TextMobile.DataBindings.Add("EditValue", employee, "mobile_number");
            TextNationality.DataBindings.Add("EditValue", employee, "nationality");
            //SelectReligious.SelectedText;
            //SelectMarried.SelectedText;
            //SelectBranch.SelectedItem;
            //SelectPosition.SelectedItem;
            //SelectLaborContractType.SelectedIndex;
            TextEducated.DataBindings.Add("EditValue", employee, "educated");
            TextSalary.DataBindings.Add("EditValue", employee, "basic_salary");
            TextATM.DataBindings.Add("EditValue", employee, "atm");
            TextInsuranceNum.DataBindings.Add("EditValue", employee, "insurance_number");
            DateInsuranceDate.DataBindings.Add("EditValue", employee, "insurance_date");
            TextLaborContractID.DataBindings.Add("EditValue", employee, "labor_contract_number");
            //PicThumbnail.DataBindings.Add("EditValue", employee, "image", true);
            load_picture();
        }
        private void binding_combobox_data()
        {
            SelectGender.Items.Add(new { Text = "Nữ", Value = 0 });
            SelectGender.Items.Add(new { Text = "Nam", Value = 1 });
            SelectGender.DisplayMember = "Text";
            SelectGender.ValueMember = "Value";
        }
       
        private void TextFistname_Validating(object sender, CancelEventArgs e)
        {
            validate_form();
        }

        private void FormEmployeeDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void BBar_SaveClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            validate_form();
            if (validate_form() == true)
            {
                try
                {
                    Save();
                    save_status = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi không mong muốn sãy ra, không thể lưu dữ liệu\n\n" + ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); //binding_data();
                }
            }
        }

        private void FormEmployeeDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && save_status == false)
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            UOW.ReloadChangedObjects();
            employee.Reload();
            //if (e.CloseReason == CloseReason.WindowsShutDown)
            
            
        }

        private void FormEmployeeDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void BBar_SaveOnly_ItemClick(object sender, ItemClickEventArgs e)
        {
            validate_form();
            if (validate_form() == true)
            {
                try
                {
                    Save();
                    save_status = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi không mong muốn sãy ra, không thể lưu dữ liệu\n\n" + ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();//binding_data();
                }
            }
        }

        private void open_picture()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "All files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNGs|*.png";
                f.FilterIndex = 0;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(f.FileName);
                    save_picture();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void save_picture()
        {
            if (pictureBox2.Image != null)
            {
                try 
                { 
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] a = ms.GetBuffer();
                    ms.Close();
                    employee.image = a;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void load_picture()
        {
            if (employee.image != null)
            {
                try
                {
                    byte[] a = (byte[])employee.image;
                    MemoryStream ms = new MemoryStream(a);
                    pictureBox2.Image = Image.FromStream(ms);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            open_picture();
        }
    }
}