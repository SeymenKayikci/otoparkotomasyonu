namespace OtoparkOtomasyonu1
{
	partial class musteri
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
			this.otoparkOtomasyonuDataSet = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSet();
			this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.musteriTableAdapter = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSetTableAdapters.musteriTableAdapter();
			this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.musteriadsoyadDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.musteriBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(334, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(465, 290);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// otoparkOtomasyonuDataSet
			// 
			this.otoparkOtomasyonuDataSet.DataSetName = "otoparkOtomasyonuDataSet";
			this.otoparkOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// musteriBindingSource
			// 
			this.musteriBindingSource.DataMember = "musteri";
			this.musteriBindingSource.DataSource = this.otoparkOtomasyonuDataSet;
			// 
			// musteriTableAdapter
			// 
			this.musteriTableAdapter.ClearBeforeFill = true;
			// 
			// musteriidDataGridViewTextBoxColumn
			// 
			this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
			this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
			// 
			// musteriadsoyadDataGridViewTextBoxColumn
			// 
			this.musteriadsoyadDataGridViewTextBoxColumn.DataPropertyName = "musteri_ad_soyad";
			this.musteriadsoyadDataGridViewTextBoxColumn.HeaderText = "musteri_ad_soyad";
			this.musteriadsoyadDataGridViewTextBoxColumn.Name = "musteriadsoyadDataGridViewTextBoxColumn";
			// 
			// adresDataGridViewTextBoxColumn
			// 
			this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
			this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
			this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
			// 
			// telnoDataGridViewTextBoxColumn
			// 
			this.telnoDataGridViewTextBoxColumn.DataPropertyName = "tel_no";
			this.telnoDataGridViewTextBoxColumn.HeaderText = "tel_no";
			this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(334, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.Location = new System.Drawing.Point(524, 322);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 41);
			this.button2.TabIndex = 2;
			this.button2.Text = "Guncelle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(687, 322);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 41);
			this.button3.TabIndex = 3;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(129, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(129, 161);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(129, 105);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(129, 224);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(152, 20);
			this.textBox4.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Musteri ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Musteri Ad Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Musteri Adres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Musteri Telefon";
			// 
			// musteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "musteri";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.musteri_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private otoparkOtomasyonuDataSet otoparkOtomasyonuDataSet;
		private System.Windows.Forms.BindingSource musteriBindingSource;
		private otoparkOtomasyonuDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn musteriadsoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}