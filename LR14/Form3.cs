using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR14
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daysWorked = int.Parse(textBox1.Text);
            double dailyRate = double.Parse(textBox2.Text);
            textBox3.Text = Math.Round((daysWorked * dailyRate), 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0]; // Открываем главную форму
            f1.Show(); // Показываем главную форму
            this.Hide(); // Скрываем текущую форму
        }
    }
}
