using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.IO;

namespace Vokabeltrainer
{
    public partial class Vorbereiten : MaterialForm
    {
        private string sFilePath = string.Empty;
        private string sFileContent = string.Empty;

        private string[] currentLine = new string[2];

        //Used for chaning the theme after the initial init.
        private MaterialSkinManager materialSkinManager = null;

        public Vorbereiten()
        {
            InitializeComponent();

            //New instance of the MaterialSkinManager
            this.materialSkinManager = MaterialSkinManager.Instance;
            //Allows the material skin addon to manage the current font
            materialSkinManager.AddFormToManage(this);
            //Sets the main theme of the form
           //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Sets the color scheme used by buttons, textboxes, etc...
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue100, TextShade.WHITE);

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = sFilePath.Length > 0 ? sFilePath : "c:\\";
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

        private void LoadWords()
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
                    reader.Close();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int x = 0;
            sFileContent = "";
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
                writer.Close();
            }
        }
    }
}