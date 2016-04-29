using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervaciaMiesteniek
{
    public partial class AddUserWindow : Form
    {
        public AddUserWindow()
        {
            InitializeComponent();
            textBox2.PasswordChar = '\u2022';
            textBox3.PasswordChar = '\u2022';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
