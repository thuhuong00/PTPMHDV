
namespace BanTinCovid
{
    partial class frmTinhHinhChung
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tinhHinhChungViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaNhiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuaKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuVong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NgayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.CaNhiemTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ChuaKhoiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TuVongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MaNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhHinhChungViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NgayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaNhiemTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuaKhoiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuVongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tinhHinhChungViewModelBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(23, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1168, 227);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tinhHinhChungViewModelBindingSource
            // 
            this.tinhHinhChungViewModelBindingSource.DataSource = typeof(BanTinCovidAPI.Models.TinhHinhChungViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay,
            this.colCaNhiem,
            this.colChuaKhoi,
            this.colTuVong,
            this.colMaNhanVien});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MinWidth = 31;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 0;
            this.colNgay.Width = 117;
            // 
            // colCaNhiem
            // 
            this.colCaNhiem.FieldName = "CaNhiem";
            this.colCaNhiem.MinWidth = 31;
            this.colCaNhiem.Name = "colCaNhiem";
            this.colCaNhiem.Visible = true;
            this.colCaNhiem.VisibleIndex = 1;
            this.colCaNhiem.Width = 117;
            // 
            // colChuaKhoi
            // 
            this.colChuaKhoi.FieldName = "ChuaKhoi";
            this.colChuaKhoi.MinWidth = 31;
            this.colChuaKhoi.Name = "colChuaKhoi";
            this.colChuaKhoi.Visible = true;
            this.colChuaKhoi.VisibleIndex = 2;
            this.colChuaKhoi.Width = 117;
            // 
            // colTuVong
            // 
            this.colTuVong.FieldName = "TuVong";
            this.colTuVong.MinWidth = 31;
            this.colTuVong.Name = "colTuVong";
            this.colTuVong.Visible = true;
            this.colTuVong.VisibleIndex = 3;
            this.colTuVong.Width = 117;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 31;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 4;
            this.colMaNhanVien.Width = 117;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1099, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1099, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1099, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tải lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1099, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hủy\'";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.NgayDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CaNhiemTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ChuaKhoiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TuVongTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MaNhanVienTextEdit);
            this.dataLayoutControl1.DataSource = this.tinhHinhChungViewModelBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 265);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(969, 167);
            this.dataLayoutControl1.TabIndex = 5;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NgayDateEdit
            // 
            this.NgayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhHinhChungViewModelBindingSource, "Ngay", true));
            this.NgayDateEdit.EditValue = null;
            this.NgayDateEdit.Location = new System.Drawing.Point(103, 12);
            this.NgayDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.NgayDateEdit.Name = "NgayDateEdit";
            this.NgayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayDateEdit.Size = new System.Drawing.Size(854, 22);
            this.NgayDateEdit.StyleController = this.dataLayoutControl1;
            this.NgayDateEdit.TabIndex = 9;
            // 
            // CaNhiemTextEdit
            // 
            this.CaNhiemTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhHinhChungViewModelBindingSource, "CaNhiem", true));
            this.CaNhiemTextEdit.Location = new System.Drawing.Point(103, 38);
            this.CaNhiemTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CaNhiemTextEdit.Name = "CaNhiemTextEdit";
            this.CaNhiemTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CaNhiemTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CaNhiemTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CaNhiemTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CaNhiemTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.CaNhiemTextEdit.Size = new System.Drawing.Size(854, 22);
            this.CaNhiemTextEdit.StyleController = this.dataLayoutControl1;
            this.CaNhiemTextEdit.TabIndex = 10;
            // 
            // ChuaKhoiTextEdit
            // 
            this.ChuaKhoiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhHinhChungViewModelBindingSource, "ChuaKhoi", true));
            this.ChuaKhoiTextEdit.Location = new System.Drawing.Point(103, 64);
            this.ChuaKhoiTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ChuaKhoiTextEdit.Name = "ChuaKhoiTextEdit";
            this.ChuaKhoiTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ChuaKhoiTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ChuaKhoiTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ChuaKhoiTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.ChuaKhoiTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.ChuaKhoiTextEdit.Size = new System.Drawing.Size(854, 22);
            this.ChuaKhoiTextEdit.StyleController = this.dataLayoutControl1;
            this.ChuaKhoiTextEdit.TabIndex = 11;
            // 
            // TuVongTextEdit
            // 
            this.TuVongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhHinhChungViewModelBindingSource, "TuVong", true));
            this.TuVongTextEdit.Location = new System.Drawing.Point(103, 90);
            this.TuVongTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.TuVongTextEdit.Name = "TuVongTextEdit";
            this.TuVongTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TuVongTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TuVongTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TuVongTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TuVongTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.TuVongTextEdit.Size = new System.Drawing.Size(854, 22);
            this.TuVongTextEdit.StyleController = this.dataLayoutControl1;
            this.TuVongTextEdit.TabIndex = 12;
            // 
            // MaNhanVienTextEdit
            // 
            this.MaNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhHinhChungViewModelBindingSource, "MaNhanVien", true));
            this.MaNhanVienTextEdit.Location = new System.Drawing.Point(103, 116);
            this.MaNhanVienTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.MaNhanVienTextEdit.Name = "MaNhanVienTextEdit";
            this.MaNhanVienTextEdit.Size = new System.Drawing.Size(854, 22);
            this.MaNhanVienTextEdit.StyleController = this.dataLayoutControl1;
            this.MaNhanVienTextEdit.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(969, 167);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 147);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NgayDateEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForNgay";
            this.layoutControlItem1.Size = new System.Drawing.Size(949, 26);
            this.layoutControlItem1.Text = "Ngay";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CaNhiemTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "ItemForCaNhiem";
            this.layoutControlItem2.Size = new System.Drawing.Size(949, 26);
            this.layoutControlItem2.Text = "Ca Nhiem";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ChuaKhoiTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "ItemForChuaKhoi";
            this.layoutControlItem3.Size = new System.Drawing.Size(949, 26);
            this.layoutControlItem3.Text = "Chua Khoi";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TuVongTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "ItemForTuVong";
            this.layoutControlItem4.Size = new System.Drawing.Size(949, 26);
            this.layoutControlItem4.Text = "Tu Vong";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.MaNhanVienTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "ItemForMaNhanVien";
            this.layoutControlItem5.Size = new System.Drawing.Size(949, 43);
            this.layoutControlItem5.Text = "Ma Nhan Vien";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 16);
            // 
            // frmTinhHinhChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 475);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmTinhHinhChung";
            this.Text = "frmTinhHinhChung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhHinhChungViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NgayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaNhiemTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuaKhoiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuVongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tinhHinhChungViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colCaNhiem;
        private DevExpress.XtraGrid.Columns.GridColumn colChuaKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTuVong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit NgayDateEdit;
        private DevExpress.XtraEditors.TextEdit CaNhiemTextEdit;
        private DevExpress.XtraEditors.TextEdit ChuaKhoiTextEdit;
        private DevExpress.XtraEditors.TextEdit TuVongTextEdit;
        private DevExpress.XtraEditors.TextEdit MaNhanVienTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}