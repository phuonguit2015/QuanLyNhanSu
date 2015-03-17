namespace LeTien.Screens.List
{
    partial class FormList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_Employee = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_ChiNhanh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_ChucVu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_DanToc = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_QuocTich = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Attendance = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_CaLamViec = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_KHChamCong = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_NgayLe = new DevExpress.XtraNavBar.NavBarItem();
            this.PPanel_Content = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPanel_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup_Employee;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_Employee,
            this.navBarGroup_Attendance});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_ChiNhanh,
            this.navBarItem_ChucVu,
            this.navBarItem_DanToc,
            this.navBarItem_QuocTich,
            this.navBarItem_CaLamViec,
            this.navBarItem_KHChamCong,
            this.navBarItem_NgayLe});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 409);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup_Employee
            // 
            this.navBarGroup_Employee.Caption = "Danh Mục Nhân Sự";
            this.navBarGroup_Employee.Expanded = true;
            this.navBarGroup_Employee.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup_Employee.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_ChiNhanh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_ChucVu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_DanToc),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_QuocTich)});
            this.navBarGroup_Employee.Name = "navBarGroup_Employee";
            this.navBarGroup_Employee.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup_Employee.SmallImage")));
            // 
            // navBarItem_ChiNhanh
            // 
            this.navBarItem_ChiNhanh.Caption = "Chi Nhánh";
            this.navBarItem_ChiNhanh.Name = "navBarItem_ChiNhanh";
            this.navBarItem_ChiNhanh.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_ChiNhanh.SmallImage")));
            this.navBarItem_ChiNhanh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_ChiNhanh_LinkClicked);
            // 
            // navBarItem_ChucVu
            // 
            this.navBarItem_ChucVu.Caption = "Chức Vụ";
            this.navBarItem_ChucVu.Name = "navBarItem_ChucVu";
            this.navBarItem_ChucVu.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_ChucVu.SmallImage")));
            // 
            // navBarItem_DanToc
            // 
            this.navBarItem_DanToc.Caption = "Dân Tộc";
            this.navBarItem_DanToc.Name = "navBarItem_DanToc";
            this.navBarItem_DanToc.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_DanToc.SmallImage")));
            // 
            // navBarItem_QuocTich
            // 
            this.navBarItem_QuocTich.Caption = "Quốc Tịch";
            this.navBarItem_QuocTich.Name = "navBarItem_QuocTich";
            this.navBarItem_QuocTich.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_QuocTich.SmallImage")));
            // 
            // navBarGroup_Attendance
            // 
            this.navBarGroup_Attendance.Caption = "Danh Mục Chấm Công";
            this.navBarGroup_Attendance.Expanded = true;
            this.navBarGroup_Attendance.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup_Attendance.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_CaLamViec),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_KHChamCong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_NgayLe)});
            this.navBarGroup_Attendance.Name = "navBarGroup_Attendance";
            this.navBarGroup_Attendance.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup_Attendance.SmallImage")));
            // 
            // navBarItem_CaLamViec
            // 
            this.navBarItem_CaLamViec.Caption = "Ca Làm Việc";
            this.navBarItem_CaLamViec.Name = "navBarItem_CaLamViec";
            this.navBarItem_CaLamViec.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_CaLamViec.SmallImage")));
            // 
            // navBarItem_KHChamCong
            // 
            this.navBarItem_KHChamCong.Caption = "Ký Hiệu Chấm Công";
            this.navBarItem_KHChamCong.Name = "navBarItem_KHChamCong";
            this.navBarItem_KHChamCong.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_KHChamCong.SmallImage")));
            // 
            // navBarItem_NgayLe
            // 
            this.navBarItem_NgayLe.Caption = "Ngày Nghĩ, Ngày Lễ";
            this.navBarItem_NgayLe.Name = "navBarItem_NgayLe";
            this.navBarItem_NgayLe.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_NgayLe.SmallImage")));
            // 
            // PPanel_Content
            // 
            this.PPanel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPanel_Content.Location = new System.Drawing.Point(193, 0);
            this.PPanel_Content.Name = "PPanel_Content";
            this.PPanel_Content.Size = new System.Drawing.Size(775, 409);
            this.PPanel_Content.TabIndex = 1;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 409);
            this.Controls.Add(this.PPanel_Content);
            this.Controls.Add(this.navBarControl1);
            this.Name = "FormList";
            this.Text = "Danh mục chương trình";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPanel_Content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Employee;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Attendance;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_ChiNhanh;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_ChucVu;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_DanToc;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_QuocTich;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_CaLamViec;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_KHChamCong;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_NgayLe;
        private DevExpress.XtraEditors.PanelControl PPanel_Content;

    }
}