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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lernen));
            this.Tc_main = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPlay = new System.Windows.Forms.TabPage();
            this.txtLastTry = new MaterialSkin.Controls.MaterialLabel();
            this.btnEnd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbEngGer = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbGerEng = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnCheckSolution = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tfSolution = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfVocab = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.tfName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClearConsole = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tfLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbDeleteVocab = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnAddVocabs = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mbDarkTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Ts_main = new MaterialSkin.Controls.MaterialTabSelector();
            this.cheatNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtCurrentTry = new MaterialSkin.Controls.MaterialLabel();
            this.Tc_main.SuspendLayout();
            this.tpPlay.SuspendLayout();
            this.tbSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_main
            // 
            this.Tc_main.Controls.Add(this.tpPlay);
            this.Tc_main.Controls.Add(this.tbSettings);
            this.Tc_main.Depth = 0;
            this.Tc_main.Location = new System.Drawing.Point(0, 105);
            this.Tc_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tc_main.Name = "Tc_main";
            this.Tc_main.SelectedIndex = 0;
            this.Tc_main.Size = new System.Drawing.Size(518, 251);
            this.Tc_main.TabIndex = 11;
            // 
            // tpPlay
            // 
            this.tpPlay.Controls.Add(this.txtCurrentTry);
            this.tpPlay.Controls.Add(this.txtLastTry);
            this.tpPlay.Controls.Add(this.btnEnd);
            this.tpPlay.Controls.Add(this.rbEngGer);
            this.tpPlay.Controls.Add(this.rbGerEng);
            this.tpPlay.Controls.Add(this.btnCheckSolution);
            this.tpPlay.Controls.Add(this.btnNext);
            this.tpPlay.Controls.Add(this.lblResult);
            this.tpPlay.Controls.Add(this.materialLabel2);
            this.tpPlay.Controls.Add(this.tfSolution);
            this.tpPlay.Controls.Add(this.tfVocab);
            this.tpPlay.Controls.Add(this.materialLabel1);
            this.tpPlay.Location = new System.Drawing.Point(4, 22);
            this.tpPlay.Name = "tpPlay";
            this.tpPlay.Size = new System.Drawing.Size(510, 225);
            this.tpPlay.TabIndex = 3;
            this.tpPlay.Text = "Vokabeltrainer";
            // 
            // txtLastTry
            // 
            this.txtLastTry.AutoSize = true;
            this.txtLastTry.Depth = 0;
            this.txtLastTry.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtLastTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLastTry.Location = new System.Drawing.Point(8, 192);
            this.txtLastTry.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastTry.Name = "txtLastTry";
            this.txtLastTry.Size = new System.Drawing.Size(204, 19);
            this.txtLastTry.TabIndex = 23;
            this.txtLastTry.Text = "Fehler in % (Letzter Versuch):";
            // 
            // btnEnd
            // 
            this.btnEnd.AutoSize = true;
            this.btnEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnd.Depth = 0;
            this.btnEnd.Icon = null;
            this.btnEnd.Location = new System.Drawing.Point(335, 175);
            this.btnEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Primary = true;
            this.btnEnd.Size = new System.Drawing.Size(162, 36);
            this.btnEnd.TabIndex = 22;
            this.btnEnd.Text = "Ergebnis Speichern";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // rbEngGer
            // 
            this.rbEngGer.AutoSize = true;
            this.rbEngGer.Checked = true;
            this.rbEngGer.Depth = 0;
            this.rbEngGer.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEngGer.Location = new System.Drawing.Point(8, 148);
            this.rbEngGer.Margin = new System.Windows.Forms.Padding(0);
            this.rbEngGer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEngGer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEngGer.Name = "rbEngGer";
            this.rbEngGer.Ripple = true;
            this.rbEngGer.Size = new System.Drawing.Size(150, 30);
            this.rbEngGer.TabIndex = 20;
            this.rbEngGer.TabStop = true;
            this.rbEngGer.Text = "Englisch -> Deutsch";
            this.rbEngGer.UseVisualStyleBackColor = true;
            this.rbEngGer.CheckedChanged += new System.EventHandler(this.rbEngGer_CheckedChanged);
            // 
            // rbGerEng
            // 
            this.rbGerEng.AutoSize = true;
            this.rbGerEng.Depth = 0;
            this.rbGerEng.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbGerEng.Location = new System.Drawing.Point(8, 118);
            this.rbGerEng.Margin = new System.Windows.Forms.Padding(0);
            this.rbGerEng.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbGerEng.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbGerEng.Name = "rbGerEng";
            this.rbGerEng.Ripple = true;
            this.rbGerEng.Size = new System.Drawing.Size(150, 30);
            this.rbGerEng.TabIndex = 19;
            this.rbGerEng.Text = "Deutsch -> Englisch";
            this.rbGerEng.UseVisualStyleBackColor = true;
            this.rbGerEng.CheckedChanged += new System.EventHandler(this.rbGerEng_CheckedChanged);
            // 
            // btnCheckSolution
            // 
            this.btnCheckSolution.AutoSize = true;
            this.btnCheckSolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckSolution.Depth = 0;
            this.btnCheckSolution.Icon = null;
            this.btnCheckSolution.Location = new System.Drawing.Point(335, 60);
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
            this.btnNext.Location = new System.Drawing.Point(335, 12);
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
            this.lblResult.Location = new System.Drawing.Point(8, 99);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(376, 19);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Drücke auf \'Starten\' um den Vokabeltrainer zu starten...";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 51);
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
            this.tfSolution.Location = new System.Drawing.Point(8, 73);
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
            this.tfVocab.Location = new System.Drawing.Point(8, 25);
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
            this.materialLabel1.Location = new System.Drawing.Point(4, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Vokabel";
            // 
            // tbSettings
            // 
            this.tbSettings.Controls.Add(this.tfName);
            this.tbSettings.Controls.Add(this.btnClearConsole);
            this.tbSettings.Controls.Add(this.materialLabel4);
            this.tbSettings.Controls.Add(this.tfLocation);
            this.tbSettings.Controls.Add(this.cbDeleteVocab);
            this.tbSettings.Controls.Add(this.panel1);
            this.tbSettings.Controls.Add(this.btnAddVocabs);
            this.tbSettings.Controls.Add(this.btnReload);
            this.tbSettings.Controls.Add(this.splitter2);
            this.tbSettings.Controls.Add(this.splitter1);
            this.tbSettings.Controls.Add(this.mbDarkTheme);
            this.tbSettings.Controls.Add(this.materialLabel3);
            this.tbSettings.Location = new System.Drawing.Point(4, 22);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(510, 225);
            this.tbSettings.TabIndex = 4;
            this.tbSettings.Text = "Einstellungen";
            // 
            // tfName
            // 
            this.tfName.Depth = 0;
            this.tfName.Hint = "";
            this.tfName.Location = new System.Drawing.Point(140, 197);
            this.tfName.MaxLength = 32767;
            this.tfName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfName.Name = "tfName";
            this.tfName.PasswordChar = '\0';
            this.tfName.SelectedText = "";
            this.tfName.SelectionLength = 0;
            this.tfName.SelectionStart = 0;
            this.tfName.Size = new System.Drawing.Size(131, 23);
            this.tfName.TabIndex = 16;
            this.tfName.TabStop = false;
            this.tfName.Text = "record.txt";
            this.tfName.UseSystemPasswordChar = false;
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.AutoSize = true;
            this.btnClearConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearConsole.Depth = 0;
            this.btnClearConsole.Icon = null;
            this.btnClearConsole.Location = new System.Drawing.Point(330, 131);
            this.btnClearConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Primary = true;
            this.btnClearConsole.Size = new System.Drawing.Size(134, 36);
            this.btnClearConsole.TabIndex = 15;
            this.btnClearConsole.Text = "Konsole leeren";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 167);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(144, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Speicherdatei Name";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // tfLocation
            // 
            this.tfLocation.Depth = 0;
            this.tfLocation.Hint = "";
            this.tfLocation.Location = new System.Drawing.Point(12, 197);
            this.tfLocation.MaxLength = 32767;
            this.tfLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfLocation.Name = "tfLocation";
            this.tfLocation.PasswordChar = '\0';
            this.tfLocation.SelectedText = "";
            this.tfLocation.SelectionLength = 0;
            this.tfLocation.SelectionStart = 0;
            this.tfLocation.Size = new System.Drawing.Size(122, 23);
            this.tfLocation.TabIndex = 12;
            this.tfLocation.TabStop = false;
            this.tfLocation.Text = "words/records";
            this.tfLocation.UseSystemPasswordChar = false;
            // 
            // cbDeleteVocab
            // 
            this.cbDeleteVocab.AutoSize = true;
            this.cbDeleteVocab.Checked = true;
            this.cbDeleteVocab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleteVocab.Depth = 0;
            this.cbDeleteVocab.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbDeleteVocab.Location = new System.Drawing.Point(9, 137);
            this.cbDeleteVocab.Margin = new System.Windows.Forms.Padding(0);
            this.cbDeleteVocab.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbDeleteVocab.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbDeleteVocab.Name = "cbDeleteVocab";
            this.cbDeleteVocab.Ripple = true;
            this.cbDeleteVocab.Size = new System.Drawing.Size(230, 30);
            this.cbDeleteVocab.TabIndex = 11;
            this.cbDeleteVocab.Text = "Vokabeln automatisch entfernen";
            this.cbDeleteVocab.UseVisualStyleBackColor = true;
            this.cbDeleteVocab.CheckedChanged += new System.EventHandler(this.cbDeleteVocab_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBlue);
            this.panel1.Controls.Add(this.rbRed);
            this.panel1.Controls.Add(this.rbGreen);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 88);
            this.panel1.TabIndex = 10;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Depth = 0;
            this.rbBlue.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBlue.Location = new System.Drawing.Point(0, 0);
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
            this.rbRed.Location = new System.Drawing.Point(0, 30);
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
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Depth = 0;
            this.rbGreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbGreen.Location = new System.Drawing.Point(0, 60);
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
            // btnAddVocabs
            // 
            this.btnAddVocabs.AutoSize = true;
            this.btnAddVocabs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVocabs.Depth = 0;
            this.btnAddVocabs.Icon = null;
            this.btnAddVocabs.Location = new System.Drawing.Point(330, 76);
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
            this.btnReload.Location = new System.Drawing.Point(330, 25);
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
            this.splitter2.Size = new System.Drawing.Size(3, 225);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 225);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // mbDarkTheme
            // 
            this.mbDarkTheme.AutoSize = true;
            this.mbDarkTheme.Depth = 0;
            this.mbDarkTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.mbDarkTheme.Location = new System.Drawing.Point(9, 0);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 223);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(502, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Gemacht von Vahap Caliskan, Finn Martin, Marvin Ulrich und Joshua Ebert";
            // 
            // Ts_main
            // 
            this.Ts_main.BaseTabControl = this.Tc_main;
            this.Ts_main.Depth = 0;
            this.Ts_main.Location = new System.Drawing.Point(0, 63);
            this.Ts_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ts_main.Name = "Ts_main";
            this.Ts_main.Size = new System.Drawing.Size(518, 36);
            this.Ts_main.TabIndex = 12;
            this.Ts_main.Text = "Tabs";
            // 
            // cheatNotification
            // 
            this.cheatNotification.Text = "cheat";
            this.cheatNotification.Visible = true;
            // 
            // txtCurrentTry
            // 
            this.txtCurrentTry.AutoSize = true;
            this.txtCurrentTry.Depth = 0;
            this.txtCurrentTry.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtCurrentTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCurrentTry.Location = new System.Drawing.Point(8, 211);
            this.txtCurrentTry.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurrentTry.Name = "txtCurrentTry";
            this.txtCurrentTry.Size = new System.Drawing.Size(223, 19);
            this.txtCurrentTry.TabIndex = 24;
            this.txtCurrentTry.Text = "Fehler in % (Jetziger Versuch): 0";
            // 
            // Lernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 355);
            this.Controls.Add(this.Ts_main);
            this.Controls.Add(this.Tc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lernen";
            this.Sizable = false;
            this.Text = "Vokabeltrainer";
            this.Load += new System.EventHandler(this.Lernen_Load);
            this.Tc_main.ResumeLayout(false);
            this.tpPlay.ResumeLayout(false);
            this.tpPlay.PerformLayout();
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
        private MaterialSkin.Controls.MaterialTabControl Tc_main;
        private MaterialSkin.Controls.MaterialTabSelector Ts_main;
        private System.Windows.Forms.TabPage tpPlay;
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
        private MaterialSkin.Controls.MaterialCheckBox cbDeleteVocab;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfLocation;
        private MaterialSkin.Controls.MaterialRadioButton rbEngGer;
        private MaterialSkin.Controls.MaterialRadioButton rbGerEng;
        private MaterialSkin.Controls.MaterialRaisedButton btnClearConsole;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfName;
        private MaterialSkin.Controls.MaterialLabel txtLastTry;
        private System.Windows.Forms.NotifyIcon cheatNotification;
        private MaterialSkin.Controls.MaterialLabel txtCurrentTry;
    }
}