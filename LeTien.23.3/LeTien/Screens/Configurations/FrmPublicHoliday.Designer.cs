﻿namespace LeTien.Screens
{
    partial class FrmPublicHoliday
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
            this.components = new System.ComponentModel.Container();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(LeTien.Objects.PublicHoliday);
            this.xpCollection1.Session = this.session1;
            // 
            // session1
            // 
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(986, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(986, 416);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(962, 392);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colPublicHolidayName,
            this.colPublicHolidayStart,
            this.colPublicHolidayEnd,
            this.colPublicHolidayDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(966, 396);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colPublicHolidayName
            // 
            this.colPublicHolidayName.Caption = "Ngày lễ";
            this.colPublicHolidayName.FieldName = "PublicHolidayName";
            this.colPublicHolidayName.Name = "colPublicHolidayName";
            this.colPublicHolidayName.Visible = true;
            this.colPublicHolidayName.VisibleIndex = 0;
            // 
            // colPublicHolidayStart
            // 
            this.colPublicHolidayStart.Caption = "Từ ngày";
            this.colPublicHolidayStart.FieldName = "PublicHolidayStart";
            this.colPublicHolidayStart.Name = "colPublicHolidayStart";
            this.colPublicHolidayStart.Visible = true;
            this.colPublicHolidayStart.VisibleIndex = 1;
            // 
            // colPublicHolidayEnd
            // 
            this.colPublicHolidayEnd.Caption = "Đến ngày";
            this.colPublicHolidayEnd.FieldName = "PublicHolidayEnd";
            this.colPublicHolidayEnd.Name = "colPublicHolidayEnd";
            this.colPublicHolidayEnd.Visible = true;
            this.colPublicHolidayEnd.VisibleIndex = 2;
            // 
            // colPublicHolidayDescription
            // 
            this.colPublicHolidayDescription.Caption = "Mô tả";
            this.colPublicHolidayDescription.FieldName = "PublicHolidayDescription";
            this.colPublicHolidayDescription.Name = "colPublicHolidayDescription";
            this.colPublicHolidayDescription.Visible = true;
            this.colPublicHolidayDescription.VisibleIndex = 3;
            // 
            // FrmPublicHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 416);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPublicHoliday";
            this.Text = "Quản lý ngày lễ";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayName;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayStart;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}