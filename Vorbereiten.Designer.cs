namespace Vokabeltrainer
{
	partial class Vorbereiten
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
			this.txt_filePath = new System.Windows.Forms.TextBox();
			this.lbl_filePath = new System.Windows.Forms.Label();
			this.btn_open = new System.Windows.Forms.Button();
			this.dgv_words = new System.Windows.Forms.DataGridView();
			this.btn_save = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_words)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_filePath
			// 
			this.txt_filePath.Location = new System.Drawing.Point(71, 12);
			this.txt_filePath.Name = "txt_filePath";
			this.txt_filePath.Size = new System.Drawing.Size(293, 20);
			this.txt_filePath.TabIndex = 0;
			// 
			// lbl_filePath
			// 
			this.lbl_filePath.AutoSize = true;
			this.lbl_filePath.Location = new System.Drawing.Point(12, 15);
			this.lbl_filePath.Name = "lbl_filePath";
			this.lbl_filePath.Size = new System.Drawing.Size(53, 13);
			this.lbl_filePath.TabIndex = 1;
			this.lbl_filePath.Text = "Dateipfad";
			// 
			// btn_open
			// 
			this.btn_open.Location = new System.Drawing.Point(370, 10);
			this.btn_open.Name = "btn_open";
			this.btn_open.Size = new System.Drawing.Size(75, 23);
			this.btn_open.TabIndex = 2;
			this.btn_open.Text = "Öffnen";
			this.btn_open.UseVisualStyleBackColor = true;
			this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
			// 
			// dgv_words
			// 
			this.dgv_words.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_words.Location = new System.Drawing.Point(15, 38);
			this.dgv_words.Name = "dgv_words";
			this.dgv_words.Size = new System.Drawing.Size(430, 369);
			this.dgv_words.TabIndex = 3;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(370, 415);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(75, 23);
			this.btn_save.TabIndex = 4;
			this.btn_save.Text = "Speichern";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// Vorbereiten
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 450);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.dgv_words);
			this.Controls.Add(this.btn_open);
			this.Controls.Add(this.lbl_filePath);
			this.Controls.Add(this.txt_filePath);
			this.Name = "Vorbereiten";
			this.Text = "Vorbereiten";
			this.Load += new System.EventHandler(this.Vorbereiten_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_words)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_filePath;
		private System.Windows.Forms.Label lbl_filePath;
		private System.Windows.Forms.Button btn_open;
		private System.Windows.Forms.DataGridView dgv_words;
		private System.Windows.Forms.Button btn_save;
	}
}