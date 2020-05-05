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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btn_solution = new System.Windows.Forms.Button();
			this.btn_continue = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(297, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabStop = false;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(297, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 185);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(297, 20);
			this.textBox3.TabIndex = 2;
			// 
			// btn_solution
			// 
			this.btn_solution.Location = new System.Drawing.Point(12, 75);
			this.btn_solution.Name = "btn_solution";
			this.btn_solution.Size = new System.Drawing.Size(297, 23);
			this.btn_solution.TabIndex = 3;
			this.btn_solution.Text = "zeige Lösung";
			this.btn_solution.UseVisualStyleBackColor = true;
			this.btn_solution.Click += new System.EventHandler(this.btn_solution_Click);
			// 
			// btn_continue
			// 
			this.btn_continue.Location = new System.Drawing.Point(12, 130);
			this.btn_continue.Name = "btn_continue";
			this.btn_continue.Size = new System.Drawing.Size(297, 23);
			this.btn_continue.TabIndex = 4;
			this.btn_continue.Text = "weiter";
			this.btn_continue.UseVisualStyleBackColor = true;
			// 
			// Lernen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 450);
			this.Controls.Add(this.btn_continue);
			this.Controls.Add(this.btn_solution);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Lernen";
			this.Text = "Lernen";
			this.Load += new System.EventHandler(this.Lernen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btn_solution;
		private System.Windows.Forms.Button btn_continue;
	}
}