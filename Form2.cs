using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_App
{

    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
            textBox2.PasswordChar = '●';
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin" && textBox2.Text == "0qwe123ewq") || (textBox1.Text == "Guren" && textBox2.Text == "Gyra") || (textBox1.Text == "RadyosuYayin" && textBox2.Text == "Radyosu2019") || (textBox1.Text == "denizmina" && textBox2.Text == "mina19"))
            {
                this.Hide();
                mainForm NmainForm = new mainForm(this,textBox1.Text);
                NmainForm.Show();
            }
            else
            {
                AutoClosingMessageBox.Show("Invalid Username or Password", "Warning", 3000);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Submit_btn.PerformClick();
            }
        }
    }
}
