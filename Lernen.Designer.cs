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
            this.tpGerman = new System.Windows.Forms.TabPage();
            this.btnCheckSolution = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tfSolution = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfVocab = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tpEnglish = new System.Windows.Forms.TabPage();
            this.tbEnglishGerman = new System.Windows.Forms.TabPage();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.btnAddVocabs = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mbDarkTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.rbBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.rbGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.Ts_main = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tc_main.SuspendLayout();
            this.tpGerman.SuspendLayout();
            this.tbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_main
            // 
            this.Tc_main.Controls.Add(this.tpGerman);
            this.Tc_main.Controls.Add(this.tpEnglish);
            this.Tc_main.Controls.Add(this.tbEnglishGerman);
            this.Tc_main.Controls.Add(this.tbSettings);
            this.Tc_main.Depth = 0;
            this.Tc_main.Location = new System.Drawing.Point(0, 105);
            this.Tc_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tc_main.Name = "Tc_main";
            this.Tc_main.SelectedIndex = 0;
            this.Tc_main.Size = new System.Drawing.Size(595, 174);
            this.Tc_main.TabIndex = 11;
            // 
            // tpGerman
            // 
            this.tpGerman.Controls.Add(this.btnCheckSolution);
            this.tpGerman.Controls.Add(this.btnNext);
            this.tpGerman.Controls.Add(this.lblResult);
            this.tpGerman.Controls.Add(this.materialLabel2);
            this.tpGerman.Controls.Add(this.tfSolution);
            this.tpGerman.Controls.Add(this.tfVocab);
            this.tpGerman.Controls.Add(this.materialLabel1);
            this.tpGerman.Location = new System.Drawing.Point(4, 22);
            this.tpGerman.Name = "tpGerman";
            this.tpGerman.Size = new System.Drawing.Size(587, 148);
            this.tpGerman.TabIndex = 3;
            this.tpGerman.Text = "Deutsch";
            // 
            // btnCheckSolution
            // 
            this.btnCheckSolution.AutoSize = true;
            this.btnCheckSolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckSolution.Depth = 0;
            this.btnCheckSolution.Icon = null;
            this.btnCheckSolution.Location = new System.Drawing.Point(412, 61);
            this.btnCheckSolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckSolution.Name = "btnCheckSolution";
            this.btnCheckSolution.Primary = true;
            this.btnCheckSolution.Size = new System.Drawing.Size(163, 36);
            this.btnCheckSolution.TabIndex = 18;
            this.btnCheckSolution.Text = "Lösung überprüfen";
            this.btnCheckSolution.UseVisualStyleBackColor = true;
            this.btnCheckSolution.Click += new System.EventHandler(this.btnCheckSolution_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(429, 13);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = true;
            this.btnNext.Size = new System.Drawing.Size(146, 36);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Nächste Vokabel";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Depth = 0;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(8, 112);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 16;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Deine Lösung";
            // 
            // tfSolution
            // 
            this.tfSolution.Depth = 0;
            this.tfSolution.Hint = "";
            this.tfSolution.Location = new System.Drawing.Point(13, 74);
            this.tfSolution.MaxLength = 32767;
            this.tfSolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfSolution.Name = "tfSolution";
            this.tfSolution.PasswordChar = '\0';
            this.tfSolution.SelectedText = "";
            this.tfSolution.SelectionLength = 0;
            this.tfSolution.SelectionStart = 0;
            this.tfSolution.Size = new System.Drawing.Size(321, 23);
            this.tfSolution.TabIndex = 14;
            this.tfSolution.TabStop = false;
            this.tfSolution.UseSystemPasswordChar = false;
            // 
            // tfVocab
            // 
            this.tfVocab.Depth = 0;
            this.tfVocab.Enabled = false;
            this.tfVocab.Hint = "";
            this.tfVocab.Location = new System.Drawing.Point(13, 26);
            this.tfVocab.MaxLength = 32767;
            this.tfVocab.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfVocab.Name = "tfVocab";
            this.tfVocab.PasswordChar = '\0';
            this.tfVocab.SelectedText = "";
            this.tfVocab.SelectionLength = 0;
            this.tfVocab.SelectionStart = 0;
            this.tfVocab.Size = new System.Drawing.Size(321, 23);
            this.tfVocab.TabIndex = 13;
            this.tfVocab.TabStop = false;
            this.tfVocab.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Vokabel";
            // 
            // tpEnglish
            // 
            this.tpEnglish.Location = new System.Drawing.Point(4, 22);
            this.tpEnglish.Name = "tpEnglish";
            this.tpEnglish.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnglish.Size = new System.Drawing.Size(587, 148);
            this.tpEnglish.TabIndex = 1;
            this.tpEnglish.Text = "Englisch";
            // 
            // tbEnglishGerman
            // 
            this.tbEnglishGerman.Location = new System.Drawing.Point(4, 22);
            this.tbEnglishGerman.Name = "tbEnglishGerman";
            this.tbEnglishGerman.Padding = new System.Windows.Forms.Padding(3);
            this.tbEnglishGerman.Size = new System.Drawing.Size(587, 148);
            this.tbEnglishGerman.TabIndex = 2;
            this.tbEnglishGerman.Text = "Gemischt";
            // 
            // tbSettings
            // 
            this.tbSettings.Controls.Add(this.btnAddVocabs);
            this.tbSettings.Controls.Add(this.btnReload);
            this.tbSettings.Controls.Add(this.splitter2);
            this.tbSettings.Controls.Add(this.splitter1);
            this.tbSettings.Controls.Add(this.mbDarkTheme);
            this.tbSettings.Controls.Add(this.rbBlue);
            this.tbSettings.Controls.Add(this.rbRed);
            this.tbSettings.Controls.Add(this.materialLabel3);
            this.tbSettings.Controls.Add(this.rbGreen);
            this.tbSettings.Location = new System.Drawing.Point(4, 22);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(587, 148);
            this.tbSettings.TabIndex = 4;
            this.tbSettings.Text = "Einstellungen";
            // 
            // btnAddVocabs
            // 
            this.btnAddVocabs.AutoSize = true;
            this.btnAddVocabs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVocabs.Depth = 0;
            this.btnAddVocabs.Icon = null;
            this.btnAddVocabs.Location = new System.Drawing.Point(385, 85);
            this.btnAddVocabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddVocabs.Name = "btnAddVocabs";
            this.btnAddVocabs.Primary = true;
            this.btnAddVocabs.Size = new System.Drawing.Size(178, 36);
            this.btnAddVocabs.TabIndex = 9;
            this.btnAddVocabs.Text = "Vokabeln hinzufügen";
            this.btnAddVocabs.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.Depth = 0;
            this.btnReload.Icon = null;
            this.btnReload.Location = new System.Drawing.Point(385, 28);
            this.btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReload.Name = "btnReload";
            this.btnReload.Primary = true;
            this.btnReload.Size = new System.Drawing.Size(175, 36);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Programm neu laden ";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 148);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 148);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // mbDarkTheme
            // 
            this.mbDarkTheme.AutoSize = true;
            this.mbDarkTheme.Depth = 0;
            this.mbDarkTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.mbDarkTheme.Location = new System.Drawing.Point(6, 1);
            this.mbDarkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.mbDarkTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mbDarkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbDarkTheme.Name = "mbDarkTheme";
            this.mbDarkTheme.Ripple = true;
            this.mbDarkTheme.Size = new System.Drawing.Size(182, 30);
            this.mbDarkTheme.TabIndex = 2;
            this.mbDarkTheme.Text = "Dunkles theme benutzen";
            this.mbDarkTheme.UseVisualStyleBackColor = true;
            this.mbDarkTheme.CheckedChanged += new System.EventHandler(this.mbDarkTheme_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Depth = 0;
            this.rbBlue.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBlue.Location = new System.Drawing.Point(27, 31);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(0);
            this.rbBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Ripple = true;
            this.rbBlue.Size = new System.Drawing.Size(56, 30);
            this.rbBlue.TabIndex = 5;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blau";
            this.rbBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Depth = 0;
            this.rbRed.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRed.Location = new System.Drawing.Point(27, 61);
            this.rbRed.Margin = new System.Windows.Forms.Padding(0);
            this.rbRed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRed.Name = "rbRed";
            this.rbRed.Ripple = true;
            this.rbRed.Size = new System.Drawing.Size(50, 30);
            this.rbRed.TabIndex = 3;
            this.rbRed.Text = "Rot";
            this.rbRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(42, 124);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(502, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Gemacht von Vahap Caliskan, Finn Martin, Marvin Ulrich und Joshua Ebert";
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Depth = 0;
            this.rbGreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbGreen.Location = new System.Drawing.Point(27, 91);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(0);
            this.rbGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Ripple = true;
            this.rbGreen.Size = new System.Drawing.Size(58, 30);
            this.rbGreen.TabIndex = 4;
            this.rbGreen.Text = "Grün";
            this.rbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // Ts_main
            // 
            this.Ts_main.BaseTabControl = this.Tc_main;
            this.Ts_main.Depth = 0;
            this.Ts_main.Location = new System.Drawing.Point(0, 63);
            this.Ts_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ts_main.Name = "Ts_main";
            this.Ts_main.Size = new System.Drawing.Size(595, 36);
            this.Ts_main.TabIndex = 12;
            this.Ts_main.Text = "Tabs";
            // 
            // Lernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 277);
            this.Controls.Add(this.Ts_main);
            this.Controls.Add(this.Tc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lernen";
            this.Sizable = false;
            this.Text = "Vokabeltrainer";
            this.Load += new System.EventHandler(this.Lernen_Load);
            this.Tc_main.ResumeLayout(false);
            this.tpGerman.ResumeLayout(false);
            this.tpGerman.PerformLayout();
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
        private MaterialSkin.Controls.MaterialTabControl Tc_main;
        private System.Windows.Forms.TabPage tpEnglish;
        private MaterialSkin.Controls.MaterialTabSelector Ts_main;
        private System.Windows.Forms.TabPage tbEnglishGerman;
        private System.Windows.Forms.TabPage tpGerman;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfVocab;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tbSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfSolution;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckBox mbDarkTheme;
        private MaterialSkin.Controls.MaterialRadioButton rbBlue;
        private MaterialSkin.Controls.MaterialRadioButton rbGreen;
        private MaterialSkin.Controls.MaterialRadioButton rbRed;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddVocabs;
        private MaterialSkin.Controls.MaterialRaisedButton btnReload;
        private MaterialSkin.Controls.MaterialRaisedButton btnCheckSolution;
        private MaterialSkin.Controls.MaterialRaisedButton btnNext;
    }
}