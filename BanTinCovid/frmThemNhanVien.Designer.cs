
namespace BanTinCovid
{
    partial class frmThemNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.MaNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cccdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SoDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TrangThaiXoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MatKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NgaySinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaNhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcccd = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSoDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForemail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTrangThaiXoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.button_them = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThaiXoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcccd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTrangThaiXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm nhân viên";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.MaNhanVienTextEdit);
            this.dataLayoutControl1.Controls.Add(this.cccdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HoTenTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SoDTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiaChiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.emailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TrangThaiXoaTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MatKhauTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NgaySinhDateEdit);
            this.dataLayoutControl1.DataSource = this.nhanVienViewModelBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(36, 90);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(691, 341);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MaNhanVienTextEdit
            // 
            this.MaNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "MaNhanVien", true));
            this.MaNhanVienTextEdit.Location = new System.Drawing.Point(113, 12);
            this.MaNhanVienTextEdit.Name = "MaNhanVienTextEdit";
            this.MaNhanVienTextEdit.Size = new System.Drawing.Size(566, 22);
            this.MaNhanVienTextEdit.StyleController = this.dataLayoutControl1;
            this.MaNhanVienTextEdit.TabIndex = 4;
            // 
            // nhanVienViewModelBindingSource
            // 
            this.nhanVienViewModelBindingSource.DataSource = typeof(BanTinCovidAPI.Models.NhanVienViewModel);
            // 
            // cccdTextEdit
            // 
            this.cccdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "cccd", true));
            this.cccdTextEdit.Location = new System.Drawing.Point(113, 38);
            this.cccdTextEdit.Name = "cccdTextEdit";
            this.cccdTextEdit.Size = new System.Drawing.Size(566, 22);
            this.cccdTextEdit.StyleController = this.dataLayoutControl1;
            this.cccdTextEdit.TabIndex = 5;
            // 
            // HoTenTextEdit
            // 
            this.HoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "HoTen", true));
            this.HoTenTextEdit.Location = new System.Drawing.Point(113, 64);
            this.HoTenTextEdit.Name = "HoTenTextEdit";
            this.HoTenTextEdit.Size = new System.Drawing.Size(566, 22);
            this.HoTenTextEdit.StyleController = this.dataLayoutControl1;
            this.HoTenTextEdit.TabIndex = 6;
            // 
            // SoDTTextEdit
            // 
            this.SoDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "SoDT", true));
            this.SoDTTextEdit.Location = new System.Drawing.Point(113, 90);
            this.SoDTTextEdit.Name = "SoDTTextEdit";
            this.SoDTTextEdit.Size = new System.Drawing.Size(566, 22);
            this.SoDTTextEdit.StyleController = this.dataLayoutControl1;
            this.SoDTTextEdit.TabIndex = 7;
            // 
            // DiaChiTextEdit
            // 
            this.DiaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "DiaChi", true));
            this.DiaChiTextEdit.Location = new System.Drawing.Point(113, 116);
            this.DiaChiTextEdit.Name = "DiaChiTextEdit";
            this.DiaChiTextEdit.Size = new System.Drawing.Size(566, 22);
            this.DiaChiTextEdit.StyleController = this.dataLayoutControl1;
            this.DiaChiTextEdit.TabIndex = 8;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(113, 142);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(566, 22);
            this.emailTextEdit.StyleController = this.dataLayoutControl1;
            this.emailTextEdit.TabIndex = 9;
            // 
            // TrangThaiXoaTextEdit
            // 
            this.TrangThaiXoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "TrangThaiXoa", true));
            this.TrangThaiXoaTextEdit.Location = new System.Drawing.Point(113, 168);
            this.TrangThaiXoaTextEdit.Name = "TrangThaiXoaTextEdit";
            this.TrangThaiXoaTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TrangThaiXoaTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TrangThaiXoaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TrangThaiXoaTextEdit.Properties.Mask.EditMask = "N0";
            this.TrangThaiXoaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TrangThaiXoaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TrangThaiXoaTextEdit.Size = new System.Drawing.Size(566, 22);
            this.TrangThaiXoaTextEdit.StyleController = this.dataLayoutControl1;
            this.TrangThaiXoaTextEdit.TabIndex = 10;
            // 
            // MatKhauTextEdit
            // 
            this.MatKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "MatKhau", true));
            this.MatKhauTextEdit.Location = new System.Drawing.Point(113, 194);
            this.MatKhauTextEdit.Name = "MatKhauTextEdit";
            this.MatKhauTextEdit.Size = new System.Drawing.Size(566, 22);
            this.MatKhauTextEdit.StyleController = this.dataLayoutControl1;
            this.MatKhauTextEdit.TabIndex = 11;
            // 
            // NgaySinhDateEdit
            // 
            this.NgaySinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienViewModelBindingSource, "NgaySinh", true));
            this.NgaySinhDateEdit.EditValue = null;
            this.NgaySinhDateEdit.Location = new System.Drawing.Point(113, 220);
            this.NgaySinhDateEdit.Name = "NgaySinhDateEdit";
            this.NgaySinhDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.NgaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Size = new System.Drawing.Size(566, 22);
            this.NgaySinhDateEdit.StyleController = this.dataLayoutControl1;
            this.NgaySinhDateEdit.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(691, 341);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaNhanVien,
            this.ItemForcccd,
            this.ItemForHoTen,
            this.ItemForSoDT,
            this.ItemForDiaChi,
            this.ItemForemail,
            this.ItemForTrangThaiXoa,
            this.ItemForMatKhau,
            this.ItemForNgaySinh});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(671, 321);
            // 
            // ItemForMaNhanVien
            // 
            this.ItemForMaNhanVien.Control = this.MaNhanVienTextEdit;
            this.ItemForMaNhanVien.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaNhanVien.Name = "ItemForMaNhanVien";
            this.ItemForMaNhanVien.Size = new System.Drawing.Size(671, 26);
            this.ItemForMaNhanVien.Text = "Ma Nhan Vien";
            this.ItemForMaNhanVien.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForcccd
            // 
            this.ItemForcccd.Control = this.cccdTextEdit;
            this.ItemForcccd.Location = new System.Drawing.Point(0, 26);
            this.ItemForcccd.Name = "ItemForcccd";
            this.ItemForcccd.Size = new System.Drawing.Size(671, 26);
            this.ItemForcccd.Text = "cccd";
            this.ItemForcccd.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForHoTen
            // 
            this.ItemForHoTen.Control = this.HoTenTextEdit;
            this.ItemForHoTen.Location = new System.Drawing.Point(0, 52);
            this.ItemForHoTen.Name = "ItemForHoTen";
            this.ItemForHoTen.Size = new System.Drawing.Size(671, 26);
            this.ItemForHoTen.Text = "Ho Ten";
            this.ItemForHoTen.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForSoDT
            // 
            this.ItemForSoDT.Control = this.SoDTTextEdit;
            this.ItemForSoDT.Location = new System.Drawing.Point(0, 78);
            this.ItemForSoDT.Name = "ItemForSoDT";
            this.ItemForSoDT.Size = new System.Drawing.Size(671, 26);
            this.ItemForSoDT.Text = "So DT";
            this.ItemForSoDT.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForDiaChi
            // 
            this.ItemForDiaChi.Control = this.DiaChiTextEdit;
            this.ItemForDiaChi.Location = new System.Drawing.Point(0, 104);
            this.ItemForDiaChi.Name = "ItemForDiaChi";
            this.ItemForDiaChi.Size = new System.Drawing.Size(671, 26);
            this.ItemForDiaChi.Text = "Dia Chi";
            this.ItemForDiaChi.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForemail
            // 
            this.ItemForemail.Control = this.emailTextEdit;
            this.ItemForemail.Location = new System.Drawing.Point(0, 130);
            this.ItemForemail.Name = "ItemForemail";
            this.ItemForemail.Size = new System.Drawing.Size(671, 26);
            this.ItemForemail.Text = "email";
            this.ItemForemail.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForTrangThaiXoa
            // 
            this.ItemForTrangThaiXoa.Control = this.TrangThaiXoaTextEdit;
            this.ItemForTrangThaiXoa.Location = new System.Drawing.Point(0, 156);
            this.ItemForTrangThaiXoa.Name = "ItemForTrangThaiXoa";
            this.ItemForTrangThaiXoa.Size = new System.Drawing.Size(671, 26);
            this.ItemForTrangThaiXoa.Text = "Trang Thai Xoa";
            this.ItemForTrangThaiXoa.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForMatKhau
            // 
            this.ItemForMatKhau.Control = this.MatKhauTextEdit;
            this.ItemForMatKhau.Location = new System.Drawing.Point(0, 182);
            this.ItemForMatKhau.Name = "ItemForMatKhau";
            this.ItemForMatKhau.Size = new System.Drawing.Size(671, 26);
            this.ItemForMatKhau.Text = "Mat Khau";
            this.ItemForMatKhau.TextSize = new System.Drawing.Size(89, 16);
            // 
            // ItemForNgaySinh
            // 
            this.ItemForNgaySinh.Control = this.NgaySinhDateEdit;
            this.ItemForNgaySinh.Location = new System.Drawing.Point(0, 208);
            this.ItemForNgaySinh.Name = "ItemForNgaySinh";
            this.ItemForNgaySinh.Size = new System.Drawing.Size(671, 113);
            this.ItemForNgaySinh.Text = "Ngay Sinh";
            this.ItemForNgaySinh.TextSize = new System.Drawing.Size(89, 16);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(807, 157);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 2;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(807, 244);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 22);
            this.button_thoat.TabIndex = 3;
            this.button_thoat.Text = "Hủy";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 457);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmThemNhanVien";
            this.Text = "frmThemNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThaiXoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcccd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSoDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTrangThaiXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNgaySinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit MaNhanVienTextEdit;
        private System.Windows.Forms.BindingSource nhanVienViewModelBindingSource;
        private DevExpress.XtraEditors.TextEdit cccdTextEdit;
        private DevExpress.XtraEditors.TextEdit HoTenTextEdit;
        private DevExpress.XtraEditors.TextEdit SoDTTextEdit;
        private DevExpress.XtraEditors.TextEdit DiaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit TrangThaiXoaTextEdit;
        private DevExpress.XtraEditors.TextEdit MatKhauTextEdit;
        private DevExpress.XtraEditors.DateEdit NgaySinhDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaNhanVien;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcccd;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoTen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSoDT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForemail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTrangThaiXoa;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNgaySinh;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_thoat;
    }
}