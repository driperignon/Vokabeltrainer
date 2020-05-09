namespace Vokabeltrainer
{
	partial class Lernen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lernen));
            this.Tc_main = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Ts_main = new MaterialSkin.Controls.MaterialTabSelector();
            this.Txt_solution = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Lbl_your_solution = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_vocab = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txt_vocab = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Btn_solution = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Tc_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_main
            // 
            this.Tc_main.Controls.Add(this.tabPage1);
            this.Tc_main.Controls.Add(this.tabPage2);
            this.Tc_main.Controls.Add(this.tabPage3);
            this.Tc_main.Depth = 0;
            this.Tc_main.Location = new System.Drawing.Point(0, 105);
            this.Tc_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tc_main.Name = "Tc_main";
            this.Tc_main.SelectedIndex = 0;
            this.Tc_main.Size = new System.Drawing.Size(344, 216);
            this.Tc_main.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txt_solution);
            this.tabPage1.Controls.Add(this.Lbl_vocab);
            this.tabPage1.Controls.Add(this.Lbl_your_solution);
            this.tabPage1.Controls.Add(this.Btn_solution);
            this.tabPage1.Controls.Add(this.Txt_vocab);
            this.tabPage1.Controls.Add(this.Btn_next);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deutsch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Englisch";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ts_main
            // 
            this.Ts_main.BaseTabControl = this.Tc_main;
            this.Ts_main.Depth = 0;
            this.Ts_main.Location = new System.Drawing.Point(0, 63);
            this.Ts_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ts_main.Name = "Ts_main";
            this.Ts_main.Size = new System.Drawing.Size(344, 36);
            this.Ts_main.TabIndex = 12;
            this.Ts_main.Text = "Tabs";
            // 
            // Txt_solution
            // 
            this.Txt_solution.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_solution.Depth = 0;
            this.Txt_solution.Hint = "";
            this.Txt_solution.Location = new System.Drawing.Point(21, 108);
            this.Txt_solution.MaxLength = 32767;
            this.Txt_solution.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_solution.Name = "Txt_solution";
            this.Txt_solution.PasswordChar = '\0';
            this.Txt_solution.SelectedText = "";
            this.Txt_solution.SelectionLength = 0;
            this.Txt_solution.SelectionStart = 0;
            this.Txt_solution.Size = new System.Drawing.Size(297, 23);
            this.Txt_solution.TabIndex = 18;
            this.Txt_solution.TabStop = false;
            this.Txt_solution.UseSystemPasswordChar = false;
            // 
            // Lbl_your_solution
            // 
            this.Lbl_your_solution.AutoSize = true;
            this.Lbl_your_solution.Depth = 0;
            this.Lbl_your_solution.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_your_solution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_your_solution.Location = new System.Drawing.Point(17, 86);
            this.Lbl_your_solution.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_your_solution.Name = "Lbl_your_solution";
            this.Lbl_your_solution.Size = new System.Drawing.Size(104, 19);
            this.Lbl_your_solution.TabIndex = 17;
            this.Lbl_your_solution.Text = "Deine Lösung:";
            // 
            // Lbl_vocab
            // 
            this.Lbl_vocab.AutoSize = true;
            this.Lbl_vocab.Depth = 0;
            this.Lbl_vocab.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lbl_vocab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_vocab.Location = new System.Drawing.Point(17, 7);
            this.Lbl_vocab.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_vocab.Name = "Lbl_vocab";
            this.Lbl_vocab.Size = new System.Drawing.Size(68, 19);
            this.Lbl_vocab.TabIndex = 16;
            this.Lbl_vocab.Text = "Vokabel:";
            // 
            // Btn_next
            // 
            this.Btn_next.AutoSize = true;
            this.Btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_next.Depth = 0;
            this.Btn_next.Icon = null;
            this.Btn_next.Location = new System.Drawing.Point(172, 152);
            this.Btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Primary = false;
            this.Btn_next.Size = new System.Drawing.Size(146, 36);
            this.Btn_next.TabIndex = 15;
            this.Btn_next.Text = "Nächste Vokabel";
            this.Btn_next.UseVisualStyleBackColor = true;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click_1);
            // 
            // Txt_vocab
            // 
            this.Txt_vocab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_vocab.Depth = 0;
            this.Txt_vocab.Hint = "";
            this.Txt_vocab.Location = new System.Drawing.Point(21, 29);
            this.Txt_vocab.MaxLength = 32767;
            this.Txt_vocab.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_vocab.Name = "Txt_vocab";
            this.Txt_vocab.PasswordChar = '\0';
            this.Txt_vocab.SelectedText = "";
            this.Txt_vocab.SelectionLength = 0;
            this.Txt_vocab.SelectionStart = 0;
            this.Txt_vocab.Size = new System.Drawing.Size(297, 23);
            this.Txt_vocab.TabIndex = 14;
            this.Txt_vocab.TabStop = false;
            this.Txt_vocab.UseSystemPasswordChar = false;
            // 
            // Btn_solution
            // 
            this.Btn_solution.AutoSize = true;
            this.Btn_solution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_solution.Depth = 0;
            this.Btn_solution.Icon = null;
            this.Btn_solution.Location = new System.Drawing.Point(21, 152);
            this.Btn_solution.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_solution.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_solution.Name = "Btn_solution";
            this.Btn_solution.Primary = false;
            this.Btn_solution.Size = new System.Drawing.Size(139, 36);
            this.Btn_solution.TabIndex = 13;
            this.Btn_solution.Text = "Zeige die Lösung";
            this.Btn_solution.UseVisualStyleBackColor = true;
            this.Btn_solution.Click += new System.EventHandler(this.Btn_solution_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(336, 190);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gemischt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Lernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 320);
            this.Controls.Add(this.Ts_main);
            this.Controls.Add(this.Tc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lernen";
            this.Sizable = false;
            this.Text = "Vokabeltrainer";
            this.Load += new System.EventHandler(this.Lernen_Load);
            this.Tc_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
        private MaterialSkin.Controls.MaterialTabControl Tc_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector Ts_main;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_solution;
        private MaterialSkin.Controls.MaterialLabel Lbl_vocab;
        private MaterialSkin.Controls.MaterialLabel Lbl_your_solution;
        private MaterialSkin.Controls.MaterialFlatButton Btn_solution;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_vocab;
        private MaterialSkin.Controls.MaterialFlatButton Btn_next;
        private System.Windows.Forms.TabPage tabPage3;
    }
}