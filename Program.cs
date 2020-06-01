/**
 * File made by Joshua
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabeltrainer
{
    internal class Program
    {
        [STAThreadAttribute()]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Console.WriteLine("1. Lernen\n2. Vokabeln zum Lernen vorbereiten\n3. Beenden");
            //Test
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    /*Console.WriteLine("1. Deutsch nach Englisch\n2. Englisch nach Deutsch\n3. Gemischt\n4. Beenden");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Application.Run(new Lernen(1));
                            break;

                        case "2":
                            Application.Run(new Lernen(2));
                            break;

                        case "3":
                            Application.Run(new Lernen(3));
                            break;

                        default:
                        case "4":
                            Application.Exit();
                            break;
                    }*/
                    Application.Run(new Lernen());
                    break;

                case "2":
                    Application.Run(new Vorbereiten());
                    break;

                default:
                case "3":
                    Application.Exit();
                    break;
            }
        }
    }
}