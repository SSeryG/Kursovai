using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lStart_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2(); //создаем экземпляр класса Form2
            result.Show(); //отображаем форму с результатом
            result.Location = this.Location; //открытая форма сохраняет расположение главной формы
            this.Hide(); //скрываем главную форму
        }

        private void lExit_MouseHover(object sender, EventArgs e)
        {
            lExit.Font = new Font(lExit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lExit_MouseLeave(object sender, EventArgs e)
        {
            lExit.Font = new Font(lExit.Font, FontStyle.Bold);
        }

        private void lnfo_MouseHover(object sender, EventArgs e)
        {
            lnfo.Font = new Font(lnfo.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lnfo_MouseLeave(object sender, EventArgs e)
        {
            lnfo.Font = new Font(lnfo.Font, FontStyle.Bold);
        }

        private void lStart_MouseHover(object sender, EventArgs e)
        {
            lStart.Font = new Font(lStart.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lStart_MouseLeave(object sender, EventArgs e)
        {
            lStart.Font = new Font(lStart.Font,  FontStyle.Bold);
        }

        private void lExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnfo_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();//создаем экземпляр класса Form3
            result.Show(); //отображаем форму с результатом
            result.Location = this.Location; //открытая форма сохраняет расположение главной формы
            this.Hide(); //скрываем главную форму
        }
    }
}
