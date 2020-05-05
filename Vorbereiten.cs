using System;
using System.Windows.Forms;
using System.IO;

namespace Vokabeltrainer
{
	public partial class Vorbereiten : Form
	{
		string sFilePath = string.Empty;
		string sFileContent = string.Empty;

		string[] currentLine = new string[2];
		public Vorbereiten()
		{
			InitializeComponent();
		}

		private void btn_open_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = sFilePath.Length>0?sFilePath:"c:\\";
				openFileDialog.Filter = "Textdateien|*.txt";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					sFilePath = openFileDialog.FileName;
					txt_filePath.Text = sFilePath;

					LoadWords();

					using (StreamWriter writer = new StreamWriter("config.txt"))
					{
						writer.Write(sFilePath);
					}

					var fileStream = openFileDialog.OpenFile();
				}
			}
		}

		private void Vorbereiten_Load(object sender, EventArgs e)
		{
			if (File.Exists("config.txt"))
			{
				using (StreamReader reader = new StreamReader("config.txt"))
				{
					sFilePath = reader.ReadToEnd();
					txt_filePath.Text = sFilePath;
				}
			}

			dgv_words.ColumnCount = 2;
			dgv_words.Columns[0].Name = "Deutsch";
			dgv_words.Columns[1].Name = "Englisch";

			LoadWords();
		}

		void LoadWords()
		{
			if (sFilePath.Length != 0 && File.Exists(sFilePath))
			{
				dgv_words.Rows.Clear();
				using (StreamReader reader = new StreamReader(sFilePath))
				{
					while (!reader.EndOfStream)
					{
						currentLine = reader.ReadLine().Split(':');
						dgv_words.Rows.Add(currentLine[0], currentLine[1]);
					}
				}
			}
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			int x = 0;
			for (int i = 0; i < dgv_words.Rows.Count - 1; i++)
			{
				var row = dgv_words.Rows[i];
				foreach (DataGridViewCell cell in row.Cells)
				{
					sFileContent += cell.Value.ToString();
					if (x == 0)
						sFileContent += ":";
					x = 1;
				}
				x = 0;
				sFileContent += Environment.NewLine;
			}

			using (StreamWriter writer = new StreamWriter(sFilePath))
			{
				writer.Write(sFileContent);
			}
		}
	}
}
