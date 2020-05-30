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
    public partial class EditByNum : Form
    {
        public int number;
        public EditByNum()
        {
            InitializeComponent();

        }


        private void EditByNum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
