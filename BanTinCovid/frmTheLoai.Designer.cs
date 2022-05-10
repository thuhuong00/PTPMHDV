
namespace BanTinCovid
{
    partial class frmTheLoai
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.theLoaiViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.MoTaDataText = new System.Windows.Forms.RichTextBox();
            this.MaTheLoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenTheLoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TrangThaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaTheLoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenTheLoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTrangThai = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaTheLoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTheLoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.theLoaiViewModelBindingSource;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(531, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(865, 288);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // theLoaiViewModelBindingSource
            // 
            this.theLoaiViewModelBindingSource.DataSource = typeof(BanTinCovidAPI.Models.TheLoaiViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTheLoai,
            this.colTenTheLoai,
            this.colTrangThai,
            this.colMoTa});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.FieldName = "MaTheLoai";
            this.colMaTheLoai.MinWidth = 49;
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.Visible = true;
            this.colMaTheLoai.VisibleIndex = 0;
            this.colMaTheLoai.Width = 182;
            // 
            // colTenTheLoai
            // 
            this.colTenTheLoai.FieldName = "TenTheLoai";
            this.colTenTheLoai.MinWidth = 49;
            this.colTenTheLoai.Name = "colTenTheLoai";
            this.colTenTheLoai.Visible = true;
            this.colTenTheLoai.VisibleIndex = 1;
            this.colTenTheLoai.Width = 182;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.MinWidth = 49;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 2;
            this.colTrangThai.Width = 182;
            // 
            // colMoTa
            // 
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.MinWidth = 49;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 3;
            this.colMoTa.Width = 182;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.MoTaDataText);
            this.dataLayoutControl1.Controls.Add(this.MaTheLoaiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TenTheLoaiTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TrangThaiTextEdit);
            this.dataLayoutControl1.DataSource = this.theLoaiViewModelBindingSource;
            this.dataLayoutControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 109);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(569, 0, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(475, 211);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MoTaDataText
            // 
            this.MoTaDataText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theLoaiViewModelBindingSource, "MoTa", true));
            this.MoTaDataText.Location = new System.Drawing.Point(99, 90);
            this.MoTaDataText.Name = "MoTaDataText";
            this.MoTaDataText.Size = new System.Drawing.Size(364, 109);
            this.MoTaDataText.TabIndex = 7;
            this.MoTaDataText.Text = "";
            // 
            // MaTheLoaiTextEdit
            // 
            this.MaTheLoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.theLoaiViewModelBindingSource, "MaTheLoai", true));
            this.MaTheLoaiTextEdit.Location = new System.Drawing.Point(99, 12);
            this.MaTheLoaiTextEdit.Name = "MaTheLoaiTextEdit";
            this.MaTheLoaiTextEdit.Size = new System.Drawing.Size(364, 22);
            this.MaTheLoaiTextEdit.StyleController = this.dataLayoutControl1;
            this.MaTheLoaiTextEdit.TabIndex = 4;
            // 
            // TenTheLoaiTextEdit
            // 
            this.TenTheLoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.theLoaiViewModelBindingSource, "TenTheLoai", true));
            this.TenTheLoaiTextEdit.Location = new System.Drawing.Point(99, 38);
            this.TenTheLoaiTextEdit.Name = "TenTheLoaiTextEdit";
            this.TenTheLoaiTextEdit.Size = new System.Drawing.Size(364, 22);
            this.TenTheLoaiTextEdit.StyleController = this.dataLayoutControl1;
            this.TenTheLoaiTextEdit.TabIndex = 5;
            // 
            // TrangThaiTextEdit
            // 
            this.TrangThaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.theLoaiViewModelBindingSource, "TrangThai", true));
            this.TrangThaiTextEdit.Location = new System.Drawing.Point(99, 64);
            this.TrangThaiTextEdit.Name = "TrangThaiTextEdit";
            // 
            // 
            // 
            this.TrangThaiTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TrangThaiTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TrangThaiTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TrangThaiTextEdit.Properties.Mask.EditMask = "N0";
            this.TrangThaiTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TrangThaiTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TrangThaiTextEdit.Size = new System.Drawing.Size(364, 22);
            this.TrangThaiTextEdit.StyleController = this.dataLayoutControl1;
            this.TrangThaiTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(475, 211);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaTheLoai,
            this.ItemForTenTheLoai,
            this.ItemForTrangThai,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(455, 191);
            // 
            // ItemForMaTheLoai
            // 
            this.ItemForMaTheLoai.Control = this.MaTheLoaiTextEdit;
            this.ItemForMaTheLoai.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaTheLoai.Name = "ItemForMaTheLoai";
            this.ItemForMaTheLoai.Size = new System.Drawing.Size(455, 26);
            this.ItemForMaTheLoai.Text = "Ma The Loai";
            this.ItemForMaTheLoai.TextSize = new System.Drawing.Size(75, 16);
            // 
            // ItemForTenTheLoai
            // 
            this.ItemForTenTheLoai.Control = this.TenTheLoaiTextEdit;
            this.ItemForTenTheLoai.Location = new System.Drawing.Point(0, 26);
            this.ItemForTenTheLoai.Name = "ItemForTenTheLoai";
            this.ItemForTenTheLoai.Size = new System.Drawing.Size(455, 26);
            this.ItemForTenTheLoai.Text = "Ten The Loai";
            this.ItemForTenTheLoai.TextSize = new System.Drawing.Size(75, 16);
            // 
            // ItemForTrangThai
            // 
            this.ItemForTrangThai.Control = this.TrangThaiTextEdit;
            this.ItemForTrangThai.Location = new System.Drawing.Point(0, 52);
            this.ItemForTrangThai.Name = "ItemForTrangThai";
            this.ItemForTrangThai.Size = new System.Drawing.Size(455, 26);
            this.ItemForTrangThai.Text = "Trang Thai";
            this.ItemForTrangThai.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.MoTaDataText;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(455, 113);
            this.layoutControlItem1.Text = "Mo ta";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 16);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chỉnh sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(788, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Tải lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(932, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 525);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmTheLoai";
            this.Text = "frmTheLoai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaTheLoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTheLoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrangThaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource theLoaiViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.RichTextBox MoTaDataText;
        private DevExpress.XtraEditors.TextEdit MaTheLoaiTextEdit;
        private DevExpress.XtraEditors.TextEdit TenTheLoaiTextEdit;
        private DevExpress.XtraEditors.TextEdit TrangThaiTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaTheLoai;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenTheLoai;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTrangThai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}