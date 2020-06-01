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
			this.txt_filePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_filePath = new MaterialSkin.Controls.MaterialLabel();
			this.dgv_words = new System.Windows.Forms.DataGridView();
			this.btn_save = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_open = new MaterialSkin.Controls.MaterialRaisedButton();
			((System.ComponentModel.ISupportInitialize)(this.dgv_words)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_filePath
			// 
			this.txt_filePath.Depth = 0;
			this.txt_filePath.Hint = "";
			this.txt_filePath.Location = new System.Drawing.Point(91, 73);
			this.txt_filePath.MaxLength = 32767;
			this.txt_filePath.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_filePath.Name = "txt_filePath";
			this.txt_filePath.PasswordChar = '\0';
			this.txt_filePath.SelectedText = "";
			this.txt_filePath.SelectionLength = 0;
			this.txt_filePath.SelectionStart = 0;
			this.txt_filePath.Size = new System.Drawing.Size(285, 23);
			this.txt_filePath.TabIndex = 0;
			this.txt_filePath.TabStop = false;
			this.txt_filePath.UseSystemPasswordChar = false;
			// 
			// lbl_filePath
			// 
			this.lbl_filePath.AutoSize = true;
			this.lbl_filePath.Depth = 0;
			this.lbl_filePath.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_filePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_filePath.Location = new System.Drawing.Point(12, 75);
			this.lbl_filePath.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_filePath.Name = "lbl_filePath";
			this.lbl_filePath.Size = new System.Drawing.Size(73, 19);
			this.lbl_filePath.TabIndex = 1;
			this.lbl_filePath.Text = "Dateipfad";
			// 
			// dgv_words
			// 
			this.dgv_words.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_words.BackgroundColor = System.Drawing.Color.White;
			this.dgv_words.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_words.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_words.Location = new System.Drawing.Point(13, 109);
			this.dgv_words.Name = "dgv_words";
			this.dgv_words.Size = new System.Drawing.Size(430, 358);
			this.dgv_words.TabIndex = 3;
			// 
			// btn_save
			// 
			this.btn_save.AutoSize = true;
			this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_save.Depth = 0;
			this.btn_save.Icon = null;
			this.btn_save.Location = new System.Drawing.Point(361, 473);
			this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_save.Name = "btn_save";
			this.btn_save.Primary = true;
			this.btn_save.Size = new System.Drawing.Size(94, 36);
			this.btn_save.TabIndex = 4;
			this.btn_save.Text = "Speichern";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_open
			// 
			this.btn_open.AutoSize = true;
			this.btn_open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_open.Depth = 0;
			this.btn_open.Icon = null;
			this.btn_open.Location = new System.Drawing.Point(382, 67);
			this.btn_open.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_open.Name = "btn_open";
			this.btn_open.Primary = true;
			this.btn_open.Size = new System.Drawing.Size(73, 36);
			this.btn_open.TabIndex = 0;
			this.btn_open.Text = "Öffnen";
			this.btn_open.UseVisualStyleBackColor = true;
			this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
			// 
			// Vorbereiten
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 521);
			this.Controls.Add(this.btn_open);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.dgv_words);
			this.Controls.Add(this.lbl_filePath);
			this.Controls.Add(this.txt_filePath);
			this.MaximizeBox = false;
			this.Name = "Vorbereiten";
			this.Sizable = false;
			this.Text = "Vorbereiten";
			this.Load += new System.EventHandler(this.Vorbereiten_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_words)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField txt_filePath;
		private MaterialSkin.Controls.MaterialLabel lbl_filePath;
		public System.Windows.Forms.DataGridView dgv_words;
		private MaterialSkin.Controls.MaterialRaisedButton btn_save;
		private MaterialSkin.Controls.MaterialRaisedButton btn_open;
	}
}