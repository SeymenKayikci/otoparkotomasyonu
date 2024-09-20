namespace OtoparkOtomasyonu1
{
	partial class araclar
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.aracidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aracplakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.otoparkOtomasyonuDataSet = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSet();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.aracTableAdapter = new OtoparkOtomasyonu1.otoparkOtomasyonuDataSetTableAdapters.aracTableAdapter();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(155, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(137, 98);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(155, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(137, 189);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(155, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(137, 143);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(155, 20);
			this.textBox4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Araç Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Araç Plaka";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Araç Model";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Araç Renk";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracidDataGridViewTextBoxColumn,
            this.aracplakaDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.aracBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(2, 314);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(797, 135);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// aracidDataGridViewTextBoxColumn
			// 
			this.aracidDataGridViewTextBoxColumn.DataPropertyName = "arac_id";
			this.aracidDataGridViewTextBoxColumn.HeaderText = "arac_id";
			this.aracidDataGridViewTextBoxColumn.Name = "aracidDataGridViewTextBoxColumn";
			// 
			// aracplakaDataGridViewTextBoxColumn
			// 
			this.aracplakaDataGridViewTextBoxColumn.DataPropertyName = "arac_plaka";
			this.aracplakaDataGridViewTextBoxColumn.HeaderText = "arac_plaka";
			this.aracplakaDataGridViewTextBoxColumn.Name = "aracplakaDataGridViewTextBoxColumn";
			// 
			// renkDataGridViewTextBoxColumn
			// 
			this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
			this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
			this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "model";
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			// 
			// yilDataGridViewTextBoxColumn
			// 
			this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
			this.yilDataGridViewTextBoxColumn.HeaderText = "yil";
			this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
			// 
			// aracBindingSource
			// 
			this.aracBindingSource.DataMember = "arac";
			this.aracBindingSource.DataSource = this.otoparkOtomasyonuDataSet;
			// 
			// otoparkOtomasyonuDataSet
			// 
			this.otoparkOtomasyonuDataSet.DataSetName = "otoparkOtomasyonuDataSet";
			this.otoparkOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(636, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 9;
			this.button1.Text = "Araç Güncelle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lime;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(412, 39);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 10;
			this.button2.Text = "Araç Ekle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(521, 130);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 11;
			this.button3.Text = "Araç Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(137, 239);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(155, 20);
			this.textBox6.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Araç Yıl";
			// 
			// aracTableAdapter
			// 
			this.aracTableAdapter.ClearBeforeFill = true;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Aqua;
			this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button4.Location = new System.Drawing.Point(521, 221);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 38);
			this.button4.TabIndex = 15;
			this.button4.Text = "Plaka Sorgula";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// araclar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "araclar";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.araclar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otoparkOtomasyonuDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private otoparkOtomasyonuDataSet otoparkOtomasyonuDataSet;
		private System.Windows.Forms.BindingSource aracBindingSource;
		private otoparkOtomasyonuDataSetTableAdapters.aracTableAdapter aracTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn aracidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aracplakaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button4;
	}
}