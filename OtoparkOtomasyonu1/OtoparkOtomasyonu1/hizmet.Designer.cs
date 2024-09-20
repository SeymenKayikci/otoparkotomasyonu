namespace OtoparkOtomasyonu1
{
	partial class hizmet
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.hizmetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aracgirissaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.araccikissaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.abonelikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hizmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.otoparkOtomasyonuDataSet = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSet();
			this.hizmetTableAdapter = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSetTableAdapters.hizmetTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hizmetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hizmetidDataGridViewTextBoxColumn,
            this.aracgirissaatDataGridViewTextBoxColumn,
            this.araccikissaatDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.abonelikDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.hizmetBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(277, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(523, 290);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// hizmetidDataGridViewTextBoxColumn
			// 
			this.hizmetidDataGridViewTextBoxColumn.DataPropertyName = "hizmet_id";
			this.hizmetidDataGridViewTextBoxColumn.HeaderText = "hizmet_id";
			this.hizmetidDataGridViewTextBoxColumn.Name = "hizmetidDataGridViewTextBoxColumn";
			// 
			// aracgirissaatDataGridViewTextBoxColumn
			// 
			this.aracgirissaatDataGridViewTextBoxColumn.DataPropertyName = "arac_giris_saat";
			this.aracgirissaatDataGridViewTextBoxColumn.HeaderText = "arac_giris_saat";
			this.aracgirissaatDataGridViewTextBoxColumn.Name = "aracgirissaatDataGridViewTextBoxColumn";
			// 
			// araccikissaatDataGridViewTextBoxColumn
			// 
			this.araccikissaatDataGridViewTextBoxColumn.DataPropertyName = "arac_cikis_saat";
			this.araccikissaatDataGridViewTextBoxColumn.HeaderText = "arac_cikis_saat";
			this.araccikissaatDataGridViewTextBoxColumn.Name = "araccikissaatDataGridViewTextBoxColumn";
			// 
			// ucretDataGridViewTextBoxColumn
			// 
			this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
			this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
			this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
			// 
			// abonelikDataGridViewTextBoxColumn
			// 
			this.abonelikDataGridViewTextBoxColumn.DataPropertyName = "abonelik";
			this.abonelikDataGridViewTextBoxColumn.HeaderText = "abonelik";
			this.abonelikDataGridViewTextBoxColumn.Name = "abonelikDataGridViewTextBoxColumn";
			// 
			// plakaDataGridViewTextBoxColumn
			// 
			this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
			this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
			this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
			// 
			// hizmetBindingSource
			// 
			this.hizmetBindingSource.DataMember = "hizmet";
			this.hizmetBindingSource.DataSource = this.otoparkOtomasyonuDataSet;
			// 
			// otoparkOtomasyonuDataSet
			// 
			this.otoparkOtomasyonuDataSet.DataSetName = "otoparkOtomasyonuDataSet";
			this.otoparkOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// hizmetTableAdapter
			// 
			this.hizmetTableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(277, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.Location = new System.Drawing.Point(476, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 43);
			this.button2.TabIndex = 2;
			this.button2.Text = "Güncelle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(658, 331);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(130, 43);
			this.button3.TabIndex = 3;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(106, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(133, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(106, 58);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(106, 101);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(133, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(106, 145);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(133, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(106, 195);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(133, 20);
			this.textBox5.TabIndex = 8;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(106, 249);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(133, 20);
			this.textBox6.TabIndex = 9;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(106, 302);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(133, 20);
			this.textBox7.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Hizmet ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Müşteri Ad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Hizmet Araç Giriş";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Hizmet Araç Çıkış";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Hizmet Ücret";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 256);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Hizmet Abonelik";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 305);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Hizmet Plaka";
			// 
			// hizmet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "hizmet";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.hizmet_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hizmetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private otoparkOtomasyonuDataSet otoparkOtomasyonuDataSet;
		private System.Windows.Forms.BindingSource hizmetBindingSource;
		private otoparkOtomasyonuDataSetTableAdapters.hizmetTableAdapter hizmetTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn hizmetidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aracgirissaatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn araccikissaatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn abonelikDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}