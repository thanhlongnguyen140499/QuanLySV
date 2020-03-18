namespace CodeFisrtCuoiKy
{
    partial class Form1
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
            this.grbox_ThongTin = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbox_TenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_IDKhoa = new System.Windows.Forms.TextBox();
            this.txtbox_HoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbox_MSSV = new System.Windows.Forms.TextBox();
            this.lb_MSSV = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.txtBox_FileExcel = new System.Windows.Forms.TextBox();
            this.cbBox_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.datagr_1 = new System.Windows.Forms.DataGridView();
            this.dBexcelDEMO1DataSet = new CodeFisrtCuoiKy.DBexcelDEMO1DataSet();
            this.btn_Import1 = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import2 = new System.Windows.Forms.Button();
            this.cbbox_import2 = new System.Windows.Forms.ComboBox();
            this.btn_FileExcel = new System.Windows.Forms.Button();
            this.kHOAsTableAdapter = new CodeFisrtCuoiKy.DBexcelDEMO1DataSetTableAdapters.KHOAsTableAdapter();
            this.sVsTableAdapter = new CodeFisrtCuoiKy.DBexcelDEMO1DataSetTableAdapters.SVsTableAdapter();
            this.grbox_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagr_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBexcelDEMO1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox_ThongTin
            // 
            this.grbox_ThongTin.Controls.Add(this.textBox1);
            this.grbox_ThongTin.Controls.Add(this.txtbox_TenKhoa);
            this.grbox_ThongTin.Controls.Add(this.label3);
            this.grbox_ThongTin.Controls.Add(this.label2);
            this.grbox_ThongTin.Controls.Add(this.txtbox_IDKhoa);
            this.grbox_ThongTin.Controls.Add(this.txtbox_HoTen);
            this.grbox_ThongTin.Controls.Add(this.label1);
            this.grbox_ThongTin.Controls.Add(this.radioButton_Nu);
            this.grbox_ThongTin.Controls.Add(this.radioButton_Nam);
            this.grbox_ThongTin.Controls.Add(this.dateTimePicker1);
            this.grbox_ThongTin.Controls.Add(this.txtbox_MSSV);
            this.grbox_ThongTin.Controls.Add(this.lb_MSSV);
            this.grbox_ThongTin.Controls.Add(this.lb_HoTen);
            this.grbox_ThongTin.Location = new System.Drawing.Point(583, 32);
            this.grbox_ThongTin.Name = "grbox_ThongTin";
            this.grbox_ThongTin.Size = new System.Drawing.Size(399, 220);
            this.grbox_ThongTin.TabIndex = 88;
            this.grbox_ThongTin.TabStop = false;
            this.grbox_ThongTin.Text = "Thông tin sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 20;
            // 
            // txtbox_TenKhoa
            // 
            this.txtbox_TenKhoa.Location = new System.Drawing.Point(310, 96);
            this.txtbox_TenKhoa.Name = "txtbox_TenKhoa";
            this.txtbox_TenKhoa.Size = new System.Drawing.Size(83, 20);
            this.txtbox_TenKhoa.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Khoa";
            // 
            // txtbox_IDKhoa
            // 
            this.txtbox_IDKhoa.Location = new System.Drawing.Point(310, 65);
            this.txtbox_IDKhoa.Name = "txtbox_IDKhoa";
            this.txtbox_IDKhoa.Size = new System.Drawing.Size(83, 20);
            this.txtbox_IDKhoa.TabIndex = 16;
            // 
            // txtbox_HoTen
            // 
            this.txtbox_HoTen.Location = new System.Drawing.Point(80, 32);
            this.txtbox_HoTen.Name = "txtbox_HoTen";
            this.txtbox_HoTen.Size = new System.Drawing.Size(150, 20);
            this.txtbox_HoTen.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Điểm";
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(120, 151);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_Nu.TabIndex = 13;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Checked = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(13, 153);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nam.TabIndex = 12;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtbox_MSSV
            // 
            this.txtbox_MSSV.Location = new System.Drawing.Point(80, 65);
            this.txtbox_MSSV.Name = "txtbox_MSSV";
            this.txtbox_MSSV.Size = new System.Drawing.Size(150, 20);
            this.txtbox_MSSV.TabIndex = 10;
            // 
            // lb_MSSV
            // 
            this.lb_MSSV.AutoSize = true;
            this.lb_MSSV.Location = new System.Drawing.Point(10, 65);
            this.lb_MSSV.Name = "lb_MSSV";
            this.lb_MSSV.Size = new System.Drawing.Size(37, 13);
            this.lb_MSSV.TabIndex = 8;
            this.lb_MSSV.Text = "MSSV";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(7, 35);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(54, 13);
            this.lb_HoTen.TabIndex = 7;
            this.lb_HoTen.Text = "Họ và tên";
            // 
            // txtBox_FileExcel
            // 
            this.txtBox_FileExcel.Location = new System.Drawing.Point(616, 284);
            this.txtBox_FileExcel.Multiline = true;
            this.txtBox_FileExcel.Name = "txtBox_FileExcel";
            this.txtBox_FileExcel.Size = new System.Drawing.Size(341, 20);
            this.txtBox_FileExcel.TabIndex = 0;
            // 
            // cbBox_Sort
            // 
            this.cbBox_Sort.FormattingEnabled = true;
            this.cbBox_Sort.Items.AddRange(new object[] {
            "HoTen",
            "MSSV",
            "ID_KHOA"});
            this.cbBox_Sort.Location = new System.Drawing.Point(420, 242);
            this.cbBox_Sort.Name = "cbBox_Sort";
            this.cbBox_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbBox_Sort.TabIndex = 87;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(140, 185);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 81;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(31, 185);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 80;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(31, 240);
            this.txtBox_Search.Multiline = true;
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(154, 23);
            this.txtBox_Search.TabIndex = 86;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(31, 289);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 85;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(325, 242);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 84;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(191, 242);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 83;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(243, 185);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 82;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // datagr_1
            // 
            this.datagr_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagr_1.Location = new System.Drawing.Point(23, 32);
            this.datagr_1.Name = "datagr_1";
            this.datagr_1.Size = new System.Drawing.Size(554, 131);
            this.datagr_1.TabIndex = 79;
            this.datagr_1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagr_1_RowHeaderMouseClick);
            // 
            // dBexcelDEMO1DataSet
            // 
            this.dBexcelDEMO1DataSet.DataSetName = "DBexcelDEMO1DataSet";
            this.dBexcelDEMO1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Import1
            // 
            this.btn_Import1.Location = new System.Drawing.Point(369, 281);
            this.btn_Import1.Name = "btn_Import1";
            this.btn_Import1.Size = new System.Drawing.Size(75, 23);
            this.btn_Import1.TabIndex = 90;
            this.btn_Import1.Text = "Import1";
            this.btn_Import1.UseVisualStyleBackColor = true;
            this.btn_Import1.Click += new System.EventHandler(this.btn_Import_Click_1);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(456, 281);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 91;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // btn_Import2
            // 
            this.btn_Import2.Location = new System.Drawing.Point(369, 310);
            this.btn_Import2.Name = "btn_Import2";
            this.btn_Import2.Size = new System.Drawing.Size(75, 23);
            this.btn_Import2.TabIndex = 92;
            this.btn_Import2.Text = "Import2";
            this.btn_Import2.UseVisualStyleBackColor = true;
            this.btn_Import2.Click += new System.EventHandler(this.btn_Import2_Click);
            // 
            // cbbox_import2
            // 
            this.cbbox_import2.FormattingEnabled = true;
            this.cbbox_import2.Items.AddRange(new object[] {
            "KHACHHANG"});
            this.cbbox_import2.Location = new System.Drawing.Point(616, 312);
            this.cbbox_import2.Name = "cbbox_import2";
            this.cbbox_import2.Size = new System.Drawing.Size(121, 21);
            this.cbbox_import2.TabIndex = 93;
            this.cbbox_import2.SelectedIndexChanged += new System.EventHandler(this.cbbox_import2_SelectedIndexChanged);
            // 
            // btn_FileExcel
            // 
            this.btn_FileExcel.Location = new System.Drawing.Point(754, 310);
            this.btn_FileExcel.Name = "btn_FileExcel";
            this.btn_FileExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_FileExcel.TabIndex = 94;
            this.btn_FileExcel.Text = "...";
            this.btn_FileExcel.UseVisualStyleBackColor = true;
            this.btn_FileExcel.Click += new System.EventHandler(this.btn_FileExcel_Click);
            // 
            // kHOAsTableAdapter
            // 
            this.kHOAsTableAdapter.ClearBeforeFill = true;
            // 
            // sVsTableAdapter
            // 
            this.sVsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.btn_FileExcel);
            this.Controls.Add(this.cbbox_import2);
            this.Controls.Add(this.btn_Import2);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import1);
            this.Controls.Add(this.grbox_ThongTin);
            this.Controls.Add(this.cbBox_Sort);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_FileExcel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.datagr_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbox_ThongTin.ResumeLayout(false);
            this.grbox_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagr_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBexcelDEMO1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbox_ThongTin;
        private System.Windows.Forms.TextBox txtbox_TenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_IDKhoa;
        private System.Windows.Forms.TextBox txtbox_HoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbox_MSSV;
        private System.Windows.Forms.Label lb_MSSV;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.TextBox txtBox_FileExcel;
        private System.Windows.Forms.ComboBox cbBox_Sort;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView datagr_1;
        private System.Windows.Forms.Button btn_Import1;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import2;
        private System.Windows.Forms.ComboBox cbbox_import2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_FileExcel;
        private DBexcelDEMO1DataSet dBexcelDEMO1DataSet;
        private DBexcelDEMO1DataSetTableAdapters.KHOAsTableAdapter kHOAsTableAdapter;
        private DBexcelDEMO1DataSetTableAdapters.SVsTableAdapter sVsTableAdapter;
    }
}

