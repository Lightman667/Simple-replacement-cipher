using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptographVlasova
{
    public partial class Form1 : Form
    {
        string IshodStr;
        string IshodStr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void ZashifrovatButton_Click(object sender, EventArgs e)
        {
            IshodStr = textBox1.Text;
            IshodStr2 = IshodStr.Replace("а", "Я").Replace("б", "Ю").Replace("в", "Э").Replace("г", "Ь").
                Replace("д", "Ы").Replace("е", "Ъ").Replace("ё", "Щ").Replace("ж", "Ш").Replace("з", "Ч").
                Replace("и", "Ц").Replace("й", "Х").Replace("к", "Ф").Replace("л", "У").Replace("м", "Т").
                Replace("н", "С").Replace("о", "Р").Replace("я", "А").Replace("ю", "Б").Replace("э", "В").
                Replace("ь", "Г").Replace("ы", "Д").Replace("ъ", "Е").Replace("щ", "Ё").Replace("ш", "Ж").
                Replace("ч", "З").Replace("ц", "И").Replace("х", "Й").Replace("ф", "К").Replace("у", "Л").
                Replace("т", "М").Replace("с", "Н").Replace("р", "О").Replace("п","П");

            resultTextbox.Text = IshodStr2;
        }

        private void DeshifrovatButton_Click(object sender, EventArgs e)
        {
            IshodStr = textBox1.Text.ToUpper();
            resultTextbox.Text = IshodStr;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }
    }
}
