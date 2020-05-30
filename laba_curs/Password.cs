using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_curs
{
    public partial class Password : Form
    {
        public string N;
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToString(textBox1.Text);               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            if (N != "")
                this.DialogResult = DialogResult.OK;
        }
    }
}
