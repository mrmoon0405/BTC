namespace QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtaddresncc = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfindncc = new System.Windows.Forms.Button();
            this.cbbfindncc = new System.Windows.Forms.ComboBox();
            this.nCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet = new QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17.NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncancelncc = new System.Windows.Forms.Button();
            this.btndeletencc = new System.Windows.Forms.Button();
            this.btnaddncc = new System.Windows.Forms.Button();
            this.btnsavencc = new System.Windows.Forms.Button();
            this.btneditncc = new System.Windows.Forms.Button();
            this.btngetncc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamencc = new System.Windows.Forms.TextBox();
            this.txtaddressncc = new System.Windows.Forms.TextBox();
            this.txttelephonenumberncc = new System.Windows.Forms.TextBox();
            this.txtidncc = new System.Windows.Forms.TextBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nCCTableAdapter = new QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17.NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSetTableAdapters.NCCTableAdapter();
            this.tabControl1.SuspendLayout();
            this.txtaddresncc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.txtaddresncc);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // txtaddresncc
            // 
            this.txtaddresncc.BackColor = System.Drawing.Color.Gray;
            this.txtaddresncc.Controls.Add(this.groupBox3);
            this.txtaddresncc.Controls.Add(this.groupBox2);
            this.txtaddresncc.Controls.Add(this.groupBox1);
            this.txtaddresncc.Controls.Add(this.dgvNCC);
            this.txtaddresncc.Location = new System.Drawing.Point(4, 22);
            this.txtaddresncc.Name = "txtaddresncc";
            this.txtaddresncc.Padding = new System.Windows.Forms.Padding(3);
            this.txtaddresncc.Size = new System.Drawing.Size(748, 360);
            this.txtaddresncc.TabIndex = 0;
            this.txtaddresncc.Text = "Nhà Cung Cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnfindncc);
            this.groupBox3.Controls.Add(this.cbbfindncc);
            this.groupBox3.Location = new System.Drawing.Point(515, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 147);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Nhà Cung Cấp";
            // 
            // btnfindncc
            // 
            this.btnfindncc.Location = new System.Drawing.Point(84, 87);
            this.btnfindncc.Name = "btnfindncc";
            this.btnfindncc.Size = new System.Drawing.Size(75, 23);
            this.btnfindncc.TabIndex = 1;
            this.btnfindncc.Text = "Tìm Kiếm";
            this.btnfindncc.UseVisualStyleBackColor = true;
            this.btnfindncc.Click += new System.EventHandler(this.btnfindncc_Click);
            // 
            // cbbfindncc
            // 
            this.cbbfindncc.DataSource = this.nCCBindingSource;
            this.cbbfindncc.DisplayMember = "TenNCC";
            this.cbbfindncc.FormattingEnabled = true;
            this.cbbfindncc.Location = new System.Drawing.Point(37, 50);
            this.cbbfindncc.Name = "cbbfindncc";
            this.cbbfindncc.Size = new System.Drawing.Size(159, 21);
            this.cbbfindncc.TabIndex = 0;
            this.cbbfindncc.ValueMember = "TenNCC";
            // 
            // nCCBindingSource
            // 
            this.nCCBindingSource.DataMember = "NCC";
            this.nCCBindingSource.DataSource = this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet;
            // 
            // nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet
            // 
            this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet.DataSetName = "NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet";
            this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btncancelncc);
            this.groupBox2.Controls.Add(this.btndeletencc);
            this.groupBox2.Controls.Add(this.btnaddncc);
            this.groupBox2.Controls.Add(this.btnsavencc);
            this.groupBox2.Controls.Add(this.btneditncc);
            this.groupBox2.Controls.Add(this.btngetncc);
            this.groupBox2.Location = new System.Drawing.Point(515, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btncancelncc
            // 
            this.btncancelncc.Location = new System.Drawing.Point(128, 110);
            this.btncancelncc.Name = "btncancelncc";
            this.btncancelncc.Size = new System.Drawing.Size(75, 23);
            this.btncancelncc.TabIndex = 5;
            this.btncancelncc.Text = "Hủy";
            this.btncancelncc.UseVisualStyleBackColor = true;
            this.btncancelncc.Click += new System.EventHandler(this.btncancelncc_Click);
            // 
            // btndeletencc
            // 
            this.btndeletencc.Location = new System.Drawing.Point(128, 68);
            this.btndeletencc.Name = "btndeletencc";
            this.btndeletencc.Size = new System.Drawing.Size(75, 23);
            this.btndeletencc.TabIndex = 4;
            this.btndeletencc.Text = "Xóa";
            this.btndeletencc.UseVisualStyleBackColor = true;
            this.btndeletencc.Click += new System.EventHandler(this.btndeletencc_Click);
            // 
            // btnaddncc
            // 
            this.btnaddncc.Location = new System.Drawing.Point(128, 19);
            this.btnaddncc.Name = "btnaddncc";
            this.btnaddncc.Size = new System.Drawing.Size(75, 23);
            this.btnaddncc.TabIndex = 3;
            this.btnaddncc.Text = "Thêm";
            this.btnaddncc.UseVisualStyleBackColor = true;
            this.btnaddncc.Click += new System.EventHandler(this.btnaddncc_Click);
            // 
            // btnsavencc
            // 
            this.btnsavencc.Location = new System.Drawing.Point(19, 110);
            this.btnsavencc.Name = "btnsavencc";
            this.btnsavencc.Size = new System.Drawing.Size(75, 23);
            this.btnsavencc.TabIndex = 2;
            this.btnsavencc.Text = "Lưu";
            this.btnsavencc.UseVisualStyleBackColor = true;
            this.btnsavencc.Click += new System.EventHandler(this.btnsavencc_Click);
            // 
            // btneditncc
            // 
            this.btneditncc.Location = new System.Drawing.Point(19, 68);
            this.btneditncc.Name = "btneditncc";
            this.btneditncc.Size = new System.Drawing.Size(75, 23);
            this.btneditncc.TabIndex = 1;
            this.btneditncc.Text = "Sửa";
            this.btneditncc.UseVisualStyleBackColor = true;
            this.btneditncc.Click += new System.EventHandler(this.btneditncc_Click);
            // 
            // btngetncc
            // 
            this.btngetncc.Location = new System.Drawing.Point(18, 19);
            this.btngetncc.Name = "btngetncc";
            this.btngetncc.Size = new System.Drawing.Size(75, 23);
            this.btngetncc.TabIndex = 0;
            this.btngetncc.Text = "Hiển Thị";
            this.btngetncc.UseVisualStyleBackColor = true;
            this.btngetncc.Click += new System.EventHandler(this.btngetncc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnamencc);
            this.groupBox1.Controls.Add(this.txtaddressncc);
            this.groupBox1.Controls.Add(this.txttelephonenumberncc);
            this.groupBox1.Controls.Add(this.txtidncc);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtnamencc
            // 
            this.txtnamencc.Location = new System.Drawing.Point(86, 95);
            this.txtnamencc.Name = "txtnamencc";
            this.txtnamencc.Size = new System.Drawing.Size(100, 20);
            this.txtnamencc.TabIndex = 3;
            // 
            // txtaddressncc
            // 
            this.txtaddressncc.Location = new System.Drawing.Point(322, 40);
            this.txtaddressncc.Name = "txtaddressncc";
            this.txtaddressncc.Size = new System.Drawing.Size(100, 20);
            this.txtaddressncc.TabIndex = 2;
            // 
            // txttelephonenumberncc
            // 
            this.txttelephonenumberncc.Location = new System.Drawing.Point(322, 95);
            this.txttelephonenumberncc.Name = "txttelephonenumberncc";
            this.txttelephonenumberncc.Size = new System.Drawing.Size(100, 20);
            this.txttelephonenumberncc.TabIndex = 1;
            // 
            // txtidncc
            // 
            this.txtidncc.Location = new System.Drawing.Point(86, 40);
            this.txtidncc.Name = "txtidncc";
            this.txtidncc.Size = new System.Drawing.Size(100, 20);
            this.txtidncc.TabIndex = 0;
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(0, 210);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(484, 150);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nguyên Liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nCCTableAdapter
            // 
            this.nCCTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Quản Lý Danh Mục";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.txtaddresncc.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage txtaddresncc;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnamencc;
        private System.Windows.Forms.TextBox txtaddressncc;
        private System.Windows.Forms.TextBox txttelephonenumberncc;
        private System.Windows.Forms.TextBox txtidncc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncancelncc;
        private System.Windows.Forms.Button btndeletencc;
        private System.Windows.Forms.Button btnaddncc;
        private System.Windows.Forms.Button btnsavencc;
        private System.Windows.Forms.Button btneditncc;
        private System.Windows.Forms.Button btngetncc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbfindncc;
        private NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet;
        private System.Windows.Forms.BindingSource nCCBindingSource;
        private NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSetTableAdapters.NCCTableAdapter nCCTableAdapter;
        private System.Windows.Forms.Button btnfindncc;
        private System.Windows.Forms.Label label5;
    }
}

