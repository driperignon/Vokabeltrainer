/**
 * File made by Joshua
 */

using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Vokabeltrainer
{
    public partial class Lernen : MaterialForm
    {
        private string sFilePath = string.Empty;
        private string sFileContent = string.Empty;

        private float correctWords, wrongWords, totalWords; //Muss Kommazahl sein wegen Fehlerquote berechnen ._.

        private Boolean started = false;

        //Saves every vocab
        private List<KeyValuePair<string, string>> vocabList = new List<KeyValuePair<string, string>>();

        //Used for chaning the theme after the initial init.
        private MaterialSkinManager materialSkinManager = null;

        public Lernen()
        {
            InitializeComponent();

            //New instance of the MaterialSkinManager
            this.materialSkinManager = MaterialSkinManager.Instance;
            //Allows the material skin addon to manage the current font
            materialSkinManager.AddFormToManage(this);
            //Sets the main theme of the form
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Sets the color scheme used by buttons, textboxes, etc...
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue100, TextShade.WHITE);

            //Disables the maximize button.
            this.MaximizeBox = false;

            if (!this.started)
                this.btnNext.Text = "Starten";

            if (File.Exists(Path.Combine(this.tfLocation.Text, this.tfName.Text)))
            {
                try
                {
                    //Neue Streamreader instanz
                    StreamReader streamReader = new StreamReader(Path.Combine(this.tfLocation.Text, this.tfName.Text));
                    //Überprüft ob die Datei nicht leer ist.
                    if (streamReader.Peek() != -1)
                        this.txtLastTry.Text = $"Fehler in % (Letzter Versuch): {streamReader.ReadToEnd().Split(':')[3]}";
                    //Schließen sonst können wir später auf die Datei nicht zugreifen. :/
                    streamReader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Das hätte nicht passieren sollen :/");
                    Console.WriteLine("Ausnamentyp: " + e.GetType().ToString());
                }
            }
        }

        private void btn_solution_Click(object sender, EventArgs e)
        {
        }

        /**
         * Wird aufgerufen wenn die Form lädt
         */

        private void Lernen_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.txt"))
            {
                using (StreamReader reader = new StreamReader("config.txt"))
                {
                    sFilePath = reader.ReadToEnd();
                }
            }

            //b1g performance
            Thread loadingThread = new Thread(this.LoadWords);
            loadingThread.Start();
        }

        /**
         * Packt die vokabeln in eine Liste und inkrementiert die Variable 'totalWords'.
         */

        private void LoadWords()
        {
            //Resetet die Variable (Nützlich beim reloaden)
            this.totalWords = 0;

            //Schaut ob die Config existiert & ob ein Dateipfad angegeben wurde
            if (sFilePath.Length != 0 && File.Exists(sFilePath))
            {
                using (StreamReader reader = new StreamReader(sFilePath))
                {
                    //TODO: add reloading functionallity
                    while (!reader.EndOfStream)
                    {
                        //Inkrementiert die Variable 'totalWords' und gibt dann aus dass der Eintrag geladen wird
                        this.totalWords++;
                        Console.WriteLine($"{this.totalWords}. Wort wird geladen...");

                        //Teilt den Stream mit dem Zeichen ':' auf
                        //(streamOutput[0]=Deutsch, streamOutput[1]=Englisch
                        var streamOutput = reader.ReadLine().Split(':');

                        //Erstellt ein neues KeyValuePair Objekt welche die Vokabel beinhaltet
                        var keyValuePair = new KeyValuePair<string, string>(streamOutput[0], streamOutput[1]);

                        //Adds the KeyValuePair to our list.
                        this.vocabList.Add(keyValuePair);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ohoh... Es scheint so als würde es noch keine Vokabel geben...");
            }
        }

        /**
         * Überprüft ob die Übersetzung korrekt ist
         * argumente:
         *  translation: Das übersetzte wort
         *  vocab: Die Vokabel welche von dem Programm generiert wurde
         *
         * returns:
         *  true: Wenn die Übersetzung korrekt ist
         */

        private Boolean isTranslationCorrect(String translation, String vocab)
        {
            //Dreht die variablen Werte quasi um. Dann muss ich hier kein Zauberspruch hinschreiben
            if (this.rbGerEng.Checked)
            {
                string translationCached = translation;
                translation = vocab;
                vocab = translationCached;
            }

            foreach (KeyValuePair<string, string> keyValuePair in this.vocabList)
                if (keyValuePair.Key.ToLower().Equals(translation.ToLower()) && keyValuePair.Value.ToLower().Equals(vocab.ToLower()))
                    return true;

            return false;
        }

        /**
         * Liste wird geleert und alle Vokabeln neu hinzugefügt.
         */

        private void btnReload_Click(object sender, EventArgs e)
        {
            //Konsole leeren
            Console.Clear();
            //Liste leeren
            this.vocabList.Clear();
            //Wörter neu laden in nem neuen Thread damit das Programm nicht stehenbleibt wenn man Beispielsweise 10000 Wörter lädt
            //(Funktioniert echt bin 1 bigbrain)
            Thread loadingThread = new Thread(this.LoadWords);
            loadingThread.Start();

            //Alle werte & textfields zurücksetzen
            this.tfVocab.Clear();
            this.tfSolution.Clear();
            this.correctWords = 0;
            this.wrongWords = 0;

            //Und mal wieder den Text updaten
            this.updateText();
        }

        //Speichert ein zuvor generiertes KeyValuePair zwischen um die Lösung später zu überprüfen
        private KeyValuePair<string, string> generatedKeyValuePair;

        /**
          * Updated den info text. (Text wird einfach neu gesetzt lul)
          */

        private void updateText()
        {
            this.lblResult.Text = $"Du hast {this.wrongWords} Fehler gemacht und {this.correctWords} von {(this.cbDeleteVocab.Checked ? this.totalWords.ToString() : "∞")} Wörtern richtig übersetzt!";
            this.txtCurrentTry.Text = $"Fehler in % (Jetziger Versuch): {Math.Round(this.wrongWords / this.totalWords * 100, 0)}";
        }

        private void generateNewVocab()
        {
            //Textboxen texte werden zurückgesetzt
            this.tfVocab.Text = "";
            this.tfSolution.Text = "";

            //Falls die Vokabelliste leer ist wirds abgebrochen sonst -> IndexOutOfBoundException d:^)
            if (this.vocabList.Count == 0) return;

            //Erstellt ein neues Objekt von Random
            var random = new Random();

            //Generiertes keyValuePair wird auf ein zufällig aus der Liste genommenes KeyPair genommen
            //Hätte hier auch ein Dictionary nehmen können aber da dürfen keys nur ein mal vorkommen. (Obviously lul)
            this.generatedKeyValuePair = this.vocabList[random.Next(0, this.vocabList.Count)];

            //Text wird auf die Vokabel gesetzt.
            //Jenachdem welcher mode ausgewählt ist wird der Text gesetzt.
            if (this.rbEngGer.Checked)
            {
                this.tfVocab.Text = this.generatedKeyValuePair.Value;
            }
            else if (this.rbGerEng.Checked)
            {
                this.tfVocab.Text = this.generatedKeyValuePair.Key;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!this.started)
            {
                //Sagt, dass der Vokabeltrainer gestartet wurde. Momentan irgendwie schon useless kp
                this.started = true;
                this.btnNext.Text = "Nächste Vokabel";
            }
            this.generateNewVocab();
            this.updateText();
        }

        private void btnCheckSolution_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isTranslationCorrect(this.tfSolution.Text, this.tfVocab.Text))
                {
                    //correctWords wird inkrementiert und der info Text wird geupdated
                    this.correctWords++;

                    //Wenn vocabList die Vokabel enthält (Was sie eigentlich ab dem Punkt immer tun sollte) wird diese rausgelöscht
                    if (this.vocabList.Contains(this.generatedKeyValuePair) && cbDeleteVocab.Checked)
                        this.vocabList.Remove(this.generatedKeyValuePair);

                    //Neue Vokabel wird generiert
                    this.generateNewVocab();
                }
                else if (this.tfSolution.Text.Length != 0 && this.started)
                {
                    //Nur wenn der Text nicht leer ist und das Spiel schon gestartet ist.
                    this.wrongWords++;
                }

                this.updateText();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ohoh... Das hätte nicht passieren sollen...");
                Console.WriteLine("Ausnamentyp: " + exception.GetType().ToString());
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Schaut ob die Dateien/Ordner existieren. Wenn nicht, erstellen.
            if (!File.Exists(Path.Combine(this.tfLocation.Text, this.tfName.Text)) || !Directory.Exists(this.tfLocation.Text))
            {
                Directory.CreateDirectory(this.tfLocation.Text);
                File.Create(Path.Combine(this.tfLocation.Text, this.tfName.Text));
            }
            //Neuer Streamwriter in die Datei
            var streamWriter = new StreamWriter(Path.Combine(this.tfLocation.Text, this.tfName.Text));
            //Speichert das Ergebnis in einer Textdatei...
            //Beispiel: 11 Wörter, 11 Wörter richtig, 1 Wort falsch, Fehlerquote: ~9%
            streamWriter.WriteLine($"{this.totalWords}:{this.correctWords}:{this.wrongWords}:{Math.Round(this.wrongWords / this.totalWords * 100, 0)}");
            streamWriter.Close();
        }

        private void cbDeleteVocab_CheckedChanged(object sender, EventArgs e)
        {
            this.updateText();
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void rbGerEng_CheckedChanged(object sender, EventArgs e)
        {
            //Neue Vokabel automatisch generieren. Dann muss es der Benutzer nicht machen (Aber natürlich nur wenn das Spiel schon gestartet hat)
            if (this.started)
                this.generateNewVocab();
        }

        private void rbEngGer_CheckedChanged(object sender, EventArgs e)
        {
            //Neue Vokabel automatisch generieren. Dann muss es der Benutzer nicht machen (Aber natürlich nur wenn das Spiel schon gestartet hat)
            if (this.started)
                this.generateNewVocab();
        }

        /**
         * Alle von den Funktionen unten ändern quasi einfach nur das ColorScheme vom materialSkinManager. Klappt ganz gut und sieht mächtig aus
         */

        private void mbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (mbDarkTheme.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red500, Primary.Red500, Accent.Red100, TextShade.WHITE);
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green500, Primary.Green500, Accent.LightGreen100, TextShade.WHITE);
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue100, TextShade.WHITE);
        }
    }
}