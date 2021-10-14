namespace AplikasiLatihanTiga3
{
	partial class frmLatihanTiga3
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtPesan2 = new System.Windows.Forms.TextBox();
			this.txtPesan1 = new System.Windows.Forms.TextBox();
			this.txtPesan3 = new System.Windows.Forms.TextBox();
			this.lstPekerjaan = new System.Windows.Forms.ListBox();
			this.cmbPendidikan = new System.Windows.Forms.ComboBox();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(200, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 18);
			this.label3.TabIndex = 22;
			this.label3.Text = "PEKERJAAN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(200, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 18);
			this.label2.TabIndex = 21;
			this.label2.Text = "PENDIDIKAN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(200, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 18);
			this.label1.TabIndex = 20;
			this.label1.Text = "NAMA";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(267, 392);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(288, 37);
			this.btnOk.TabIndex = 19;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtPesan2
			// 
			this.txtPesan2.Enabled = false;
			this.txtPesan2.Location = new System.Drawing.Point(118, 285);
			this.txtPesan2.Multiline = true;
			this.txtPesan2.Name = "txtPesan2";
			this.txtPesan2.Size = new System.Drawing.Size(564, 38);
			this.txtPesan2.TabIndex = 18;
			// 
			// txtPesan1
			// 
			this.txtPesan1.Enabled = false;
			this.txtPesan1.Location = new System.Drawing.Point(118, 241);
			this.txtPesan1.Multiline = true;
			this.txtPesan1.Name = "txtPesan1";
			this.txtPesan1.Size = new System.Drawing.Size(564, 38);
			this.txtPesan1.TabIndex = 17;
			// 
			// txtPesan3
			// 
			this.txtPesan3.Enabled = false;
			this.txtPesan3.Location = new System.Drawing.Point(118, 329);
			this.txtPesan3.Multiline = true;
			this.txtPesan3.Name = "txtPesan3";
			this.txtPesan3.Size = new System.Drawing.Size(564, 38);
			this.txtPesan3.TabIndex = 16;
			// 
			// lstPekerjaan
			// 
			this.lstPekerjaan.FormattingEnabled = true;
			this.lstPekerjaan.Items.AddRange(new object[] {
            "PEDAGANG ",
            "PNS",
            "DOSEN",
            "SWASTA",
            "ABRI"});
			this.lstPekerjaan.Location = new System.Drawing.Point(363, 98);
			this.lstPekerjaan.Name = "lstPekerjaan";
			this.lstPekerjaan.Size = new System.Drawing.Size(281, 95);
			this.lstPekerjaan.TabIndex = 15;
			// 
			// cmbPendidikan
			// 
			this.cmbPendidikan.FormattingEnabled = true;
			this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "SARJANA",
            "PASCASARJANA"});
			this.cmbPendidikan.Location = new System.Drawing.Point(363, 61);
			this.cmbPendidikan.Name = "cmbPendidikan";
			this.cmbPendidikan.Size = new System.Drawing.Size(281, 21);
			this.cmbPendidikan.TabIndex = 14;
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(363, 21);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(281, 20);
			this.txtNama.TabIndex = 13;
			// 
			// frmLatihanTiga3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPesan2);
			this.Controls.Add(this.txtPesan1);
			this.Controls.Add(this.txtPesan3);
			this.Controls.Add(this.lstPekerjaan);
			this.Controls.Add(this.cmbPendidikan);
			this.Controls.Add(this.txtNama);
			this.Name = "frmLatihanTiga3";
			this.Text = "Latihan3.3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtPesan2;
		private System.Windows.Forms.TextBox txtPesan1;
		private System.Windows.Forms.TextBox txtPesan3;
		private System.Windows.Forms.ListBox lstPekerjaan;
		private System.Windows.Forms.ComboBox cmbPendidikan;
		private System.Windows.Forms.TextBox txtNama;
	}
}

