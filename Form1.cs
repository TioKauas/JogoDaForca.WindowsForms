using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] palavras = new string[]
            {
                "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA",
                "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ",
                "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA",
                "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA",
                "MANGA", "MARACUJÁ", "MURICI", "PEQUI",
                "PITANGA", "PITAYA", "SAPOTI", "TANGERINA",
                "UMBU", "UVA", "UVAIA"
            };

        Random rnd = new Random();
        string palavra = palavras[rnd.Next(0, 29)];

            char[] palavraChars = palavra.ToCharArray();

        char[] palavraLetras = Enumerable.Repeat('_', palavra.Length).ToArray();
    }
}
