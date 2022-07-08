using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.Model;
using System.IO;

namespace _1.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lMenu_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0];// создание экземпляра главной формы без создания новой копии
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            TFactory factory1 = new TFactory();//создание нового предприятия
            TextA.Text = factory1.ShowSpiFactory();//вывод списка работников
            TextB.Text = factory1.FinalyPay();//вывод зарплаты с налоговым вычетом
            TextC.Text = factory1.MeanPay();//средняя заработная плата на предприятии
            TextD.Text = factory1.MaxPay();//вывыод информации работника с максимальным окладом
        }

        private void lMenu_MouseHover(object sender, EventArgs e)
        {
            lMenu.Font = new Font(lMenu.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lMenu_MouseLeave(object sender, EventArgs e)
        {
            lMenu.Font = new Font(lMenu.Font, FontStyle.Bold);
        }

        private void lnfo2_MouseHover(object sender, EventArgs e)
        {
            lnfo2.Font = new Font(lnfo2.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lnfo2_MouseLeave(object sender, EventArgs e)
        {
            lnfo2.Font = new Font(lnfo2.Font, FontStyle.Bold);
        }

        private void lExit2_MouseHover(object sender, EventArgs e)
        {
            lExit2.Font = new Font(lExit2.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lExit2_MouseLeave(object sender, EventArgs e)
        {
            lExit2.Font = new Font(lExit2.Font, FontStyle.Bold);
        }

        private void lExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(TextA.Text);
                streamWriter.Write(TextB.Text);
                streamWriter.Write(TextC.Text);
                streamWriter.Write(TextD.Text);
                streamWriter.Close();
            }
        }

        private void lnfo2_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
    }
}
