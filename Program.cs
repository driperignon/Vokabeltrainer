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
            Application.Run(new Lernen());
        }
    }
}