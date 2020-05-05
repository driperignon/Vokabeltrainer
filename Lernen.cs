using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Vokabeltrainer
{

	public partial class Lernen : Form
	{
		string sFilePath = string.Empty;
		string sFileContent = string.Empty;
		public int wordsCount = 0;
		int iMode = 0;


		//string[,] words = new string[wordsCount, 5];

		public Lernen(int mode)
		{
			iMode = mode;
			InitializeComponent();
		}
		//getWordsCount();

		private void btn_solution_Click(object sender, EventArgs e)
		{

		}

		private void Lernen_Load(object sender, EventArgs e)
		{
			if (File.Exists("config.txt"))
			{
				using (StreamReader reader = new StreamReader("config.txt"))
				{
					sFilePath = reader.ReadToEnd();
				}
			}

			LoadWords();
		}

		void getWordsCount()
		{
			wordsCount = 0;
			using (StreamReader reader = new StreamReader(sFilePath))
			{
				while (!reader.EndOfStream)
				{
					wordsCount++;
					//currentLine = reader.ReadLine().Split(':');
					//dgv_words.Rows.Add(currentLine[0], currentLine[1]);
				}
			}
		}

		void LoadWords()
		{
			wordsCount = 0;
			if (sFilePath.Length != 0 && File.Exists(sFilePath))
			{
				//dgv_words.Rows.Clear();
				using (StreamReader reader = new StreamReader(sFilePath))
				{
					while (!reader.EndOfStream)
					{
						wordsCount++;
						//currentLine = reader.ReadLine().Split(':');
						//dgv_words.Rows.Add(currentLine[0], currentLine[1]);
					}
				}
			}
		}
	}
}
