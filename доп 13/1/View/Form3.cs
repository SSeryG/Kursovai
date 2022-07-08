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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lStart3_MouseHover(object sender, EventArgs e)
        {
            lStart3.Font = new Font(lStart3.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lStart3_MouseLeave(object sender, EventArgs e)
        {
            lStart3.Font = new Font(lStart3.Font, FontStyle.Bold);
        }

        private void lMenu2_MouseHover(object sender, EventArgs e)
        {
            lMenu2.Font = new Font(lMenu2.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lMenu2_MouseLeave(object sender, EventArgs e)
        {
            lMenu2.Font = new Font(lMenu2.Font, FontStyle.Bold);
        }

        private void lExit3_MouseHover(object sender, EventArgs e)
        {
            lExit3.Font = new Font(lExit3.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lExit3_MouseLeave(object sender, EventArgs e)
        {
            lExit3.Font = new Font(lExit3.Font, FontStyle.Bold);
        }

        private void lExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lMenu2_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0];// создание экземпляра главной формы без создания новой копии
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void lStart3_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();         
        }
    }
}
