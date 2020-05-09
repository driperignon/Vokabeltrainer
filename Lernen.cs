/**
 * File made by Joshua
 */

using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Vokabeltrainer
{
    public partial class Lernen : MaterialForm
    {
        private string sFilePath = string.Empty;
        private string sFileContent = string.Empty;
        public int wordsCount = 0;
        private int iMode = 0;

        //Used for chaning the theme after the initial init.
        private MaterialSkinManager materialSkinManager = null;

        //string[,] words = new string[wordsCount, 5];

        public Lernen(int mode)
        {
            iMode = mode;
            InitializeComponent();

            //New instance of the MaterialSkinManager
            this.materialSkinManager = MaterialSkinManager.Instance;
            //Allows the material skin addon to manage the current font
            materialSkinManager.AddFormToManage(this);
            //Sets the main theme of the form
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //Sets the color scheme used by buttons, textboxes, etc...
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue100, TextShade.WHITE);

            //Disables the maximize button.
            this.MaximizeBox = false;
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

        private void getWordsCount()
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

        private void LoadWords()
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

        private void Btn_next_Click_1(object sender, EventArgs e)
        {
            this.materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            if (Txt_solution.Text.Length <= 0) return;
        }

        private void Btn_solution_Click_1(object sender, EventArgs e)
        {
        }
    }
}