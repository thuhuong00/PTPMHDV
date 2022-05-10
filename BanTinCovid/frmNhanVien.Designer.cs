
namespace BanTinCovid
{
    partial class frmNhanVien
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
            this.nhanVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcccd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_chinhSua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nhanVienViewModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(46, 164);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1094, 314);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienViewModelBindingSource
            // 
            this.nhanVienViewModelBindingSource.DataSource = typeof(BanTinCovidAPI.Models.NhanVienViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colcccd,
            this.colHoTen,
            this.colSoDT,
            this.colDiaChi,
            this.colemail,
            this.colTrangThaiXoa,
            this.colMatKhau,
            this.colNgaySinh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 25;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 94;
            // 
            // colcccd
            // 
            this.colcccd.FieldName = "cccd";
            this.colcccd.MinWidth = 25;
            this.colcccd.Name = "colcccd";
            this.colcccd.Visible = true;
            this.colcccd.VisibleIndex = 1;
            this.colcccd.Width = 94;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 25;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 2;
            this.colHoTen.Width = 94;
            // 
            // colSoDT
            // 
            this.colSoDT.FieldName = "SoDT";
            this.colSoDT.MinWidth = 25;
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Visible = true;
            this.colSoDT.VisibleIndex = 3;
            this.colSoDT.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 94;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 25;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 5;
            this.colemail.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 6;
            this.colTrangThaiXoa.Width = 94;
            // 
            // colMatKhau
            // 
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.MinWidth = 25;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 7;
            this.colMatKhau.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 8;
            this.colNgaySinh.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(375, 64);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(121, 35);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_chinhSua
            // 
            this.button_chinhSua.Location = new System.Drawing.Point(603, 64);
            this.button_chinhSua.Name = "button_chinhSua";
            this.button_chinhSua.Size = new System.Drawing.Size(121, 35);
            this.button_chinhSua.TabIndex = 3;
            this.button_chinhSua.Text = "Chỉnh sửa";
            this.button_chinhSua.UseVisualStyleBackColor = true;
            this.button_chinhSua.Click += new System.EventHandler(this.button_chinhSua_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(165, 64);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(121, 35);
            this.button_them.TabIndex = 4;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 545);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_chinhSua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNhanVien";
            this.Text = "NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource nhanVienViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colcccd;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        public System.Windows.Forms.Button button_Xoa;
        public System.Windows.Forms.Button button_chinhSua;
        public System.Windows.Forms.Button button_them;
        public System.Windows.Forms.Button button1;
    }
}