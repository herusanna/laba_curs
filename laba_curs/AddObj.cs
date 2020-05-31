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
    public partial class AddObj : Form
    {
        List<string> sports;
        public Sportsman sportsman;
        private Form1 MyForm = Application.OpenForms[0] as Form1;
        public AddObj()
        {
            InitializeComponent();
            sports = new List<string> { "Горнолыжный спорт", "Лыжные гонки", "Прыжки с трамплина", "Лыжное двоеборье", "Фристайл", "Сноуборд", "Биатлон", "Фигурное катание", "Конькобежный спорт", "Шорт-трек", "Бобслей", "Санный спорт", "Кёрлинг" };
            comboBox1.DataSource = sports;
        }

        private void AddObj_Load(object sender, EventArgs e)
        {
            if (MyForm.k >= 0)
            {
                int i = MyForm.k;
                textBox1.Text = MyForm.sportsmen[i].sportsmen.F;
                textBox2.Text = MyForm.sportsmen[i].sportsmen.I;
                textBox3.Text = MyForm.sportsmen[i].sportsmen.O;
                textBox4.Text = MyForm.sportsmen[i].sportsmen.country;
                textBox5.Text = MyForm.sportsmen[i].sportsmen.place.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            sportsman = new Sportsman();
            try
            {
                sportsman.sportsmen.F = textBox1.Text;
                sportsman.sportsmen.I = textBox2.Text;
                sportsman.sportsmen.O = textBox3.Text;
                sportsman.sportsmen.country = textBox4.Text;
                sportsman.sportsmen.type = comboBox1.SelectedItem.ToString();
                sportsman.sportsmen.place = Convert.ToInt32(textBox5.Text);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
