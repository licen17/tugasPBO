namespace WindowsFormsApplication1
{
    partial class ListKue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListKue));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNamaKue = new System.Windows.Forms.TextBox();
            this.textUkuranKue = new System.Windows.Forms.TextBox();
            this.textJenisKue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textIDKue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBentukKue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textHargaKue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUploadPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Kue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(931, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukuran Kue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jenis Kue";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNamaKue
            // 
            this.textNamaKue.Location = new System.Drawing.Point(693, 126);
            this.textNamaKue.Margin = new System.Windows.Forms.Padding(4);
            this.textNamaKue.Name = "textNamaKue";
            this.textNamaKue.Size = new System.Drawing.Size(204, 22);
            this.textNamaKue.TabIndex = 8;
            // 
            // textUkuranKue
            // 
            this.textUkuranKue.Location = new System.Drawing.Point(1063, 126);
            this.textUkuranKue.Margin = new System.Windows.Forms.Padding(4);
            this.textUkuranKue.Name = "textUkuranKue";
            this.textUkuranKue.Size = new System.Drawing.Size(204, 22);
            this.textUkuranKue.TabIndex = 9;
            // 
            // textJenisKue
            // 
            this.textJenisKue.Location = new System.Drawing.Point(331, 155);
            this.textJenisKue.Margin = new System.Windows.Forms.Padding(4);
            this.textJenisKue.Name = "textJenisKue";
            this.textJenisKue.Size = new System.Drawing.Size(204, 22);
            this.textJenisKue.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 287);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 537);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 58);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toko Kue Enak";
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(231, 220);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(105, 49);
            this.buttonBatal.TabIndex = 13;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(385, 220);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(105, 49);
            this.buttonSimpan.TabIndex = 14;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(711, 220);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(105, 49);
            this.buttonHapus.TabIndex = 15;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(545, 220);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 49);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "List Kue";
            // 
            // textIDKue
            // 
            this.textIDKue.Location = new System.Drawing.Point(331, 123);
            this.textIDKue.Margin = new System.Windows.Forms.Padding(4);
            this.textIDKue.Name = "textIDKue";
            this.textIDKue.Size = new System.Drawing.Size(204, 22);
            this.textIDKue.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Kue";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1120, 245);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1031, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Search :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 692);
            this.panel1.TabIndex = 21;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(197, 58);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 68);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 58);
            this.button5.TabIndex = 0;
            this.button5.Text = "List Kue";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBentukKue
            // 
            this.textBentukKue.Location = new System.Drawing.Point(693, 155);
            this.textBentukKue.Margin = new System.Windows.Forms.Padding(4);
            this.textBentukKue.Name = "textBentukKue";
            this.textBentukKue.Size = new System.Drawing.Size(204, 22);
            this.textBentukKue.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bentuk Kue";
            // 
            // textHargaKue
            // 
            this.textHargaKue.Location = new System.Drawing.Point(1063, 155);
            this.textHargaKue.Margin = new System.Windows.Forms.Padding(4);
            this.textHargaKue.Name = "textHargaKue";
            this.textHargaKue.Size = new System.Drawing.Size(204, 22);
            this.textHargaKue.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(931, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Harga Kue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1044, 287);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUploadPic
            // 
            this.buttonUploadPic.Location = new System.Drawing.Point(1140, 606);
            this.buttonUploadPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadPic.Name = "buttonUploadPic";
            this.buttonUploadPic.Size = new System.Drawing.Size(116, 60);
            this.buttonUploadPic.TabIndex = 27;
            this.buttonUploadPic.Text = "Upload Picture";
            this.buttonUploadPic.UseVisualStyleBackColor = true;
            this.buttonUploadPic.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListKue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.buttonUploadPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textHargaKue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBentukKue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.textIDKue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textJenisKue);
            this.Controls.Add(this.textUkuranKue);
            this.Controls.Add(this.textNamaKue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListKue";
            this.Text = "List Kue - Toko Kue Enak";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNamaKue;
        private System.Windows.Forms.TextBox textUkuranKue;
        private System.Windows.Forms.TextBox textJenisKue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIDKue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBentukKue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textHargaKue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUploadPic;
    }
}