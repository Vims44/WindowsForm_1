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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что вы так думаете!");
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Top -= e.Y;
            button2.Left += e.X;
            if (button2.Top < -10 || button2.Top > 100)
                button2.Top = 60;
            if (button2.Left < 80 || button2.Left > 250)
                button2.Left = 120;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Действительно выйти?", "Выход из программы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2(); // Создание нового объекта
            f2.Show(); // Показ формы
        }

        private void программистToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Form f3 = new Form3(); // Создаём объект формы 3
                f3.Show(); // Показываем форму 3
                this.Hide(); // Скрываем текущую форму
        }
    }
}
