using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba_curs
{
    public partial class Form1 : Form
    {
        public List<Sportsman> sportsmen = new List<Sportsman>();
        int n;
        string password;
        public int quantity;
        public int N { get => n; set => n = value; }
        int seed = 0;
        public Form1()
        {
            InitializeComponent();
            string[] countries = { "Украина", "США", "Германия", "Англия", "Франция", "Испания", "Китай" };
            countryListBox.Items.AddRange(countries);
            countryListBox.SelectedIndexChanged += countryListBox_SelectedIndexChanged;
            string[] sports = { "Горнолыжный спорт", "Лыжные гонки", "Прыжки с трамплина", "Лыжное двоеборье", "Фристайл", "Сноуборд", "Биатлон", "Фигурное катание", "Конькобежный спорт", "Шорт-трек", "Бобслей", "Санный спорт", "Кёрлинг" };
            typeListBox.Items.AddRange(sports);
            typeListBox.SelectedIndexChanged += typeListBox_SelectedIndexChanged;
            string[] names= { "Джексон", "Ковальски", "Поттер", "Романенко", "Смит",  "Старк", "Уайт"};
            nameListBox.Items.AddRange(names);
            nameListBox.SelectedIndexChanged += nameListBox_SelectedIndexChanged;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(inputN.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
           sportsmen = new List<Sportsman>();
            nameTextBox.Clear();
            for (int i = 0; i < n; i++)
            {
                sportsmen.Add(new Sportsman(seed++));
                    nameTextBox.Text += $"[{i + 1}] { sportsmen[i].showInfo()}";                 
            }
        }
 
        private void countryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (n != 0)
            {
                infoTextBox.Clear();
                string selectedCountry = countryListBox.SelectedItem.ToString();
                MessageBox.Show("Вы выбрали " + selectedCountry);
               // int index = nameTextBox.Find(selectedCountry);
                   // index = nameTextBox.GetLineFromCharIndex(index);
                for (int index = 0; index < nameTextBox.Lines.Length; index++)
                {                
                    if (nameTextBox.Lines[index].ToString()==selectedCountry)
                    {
                        infoTextBox.Text += $"{nameTextBox.Lines[index-1].ToString()}\n";
                    }                   
                }
            }
            else
                MessageBox.Show("Для начала введите количество спортсменов!");
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (n != 0)
            {
                infoTextBox.Clear();

                string selectedSports = typeListBox.SelectedItem.ToString();
                MessageBox.Show("Вы выбрали " + selectedSports);
                //int index = nameTextBox.Find(selectedSports);
                //index = nameTextBox.GetLineFromCharIndex(index);
                for (int index = 0; index < nameTextBox.Lines.Length; index++)
                {
                    if (nameTextBox.Lines[index].ToString() == selectedSports)
                    {
                        infoTextBox.Text += $"{nameTextBox.Lines[index - 2].ToString()}\n";
                    }
                }
            }
            else
                MessageBox.Show("Для начала введите количество спортсменов!");
        }
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (n != 0)
            {
                infoTextBox.Clear();

                string selectedName = nameListBox.SelectedItem.ToString();
                MessageBox.Show("Вы выбрали " + selectedName);
                for (int index = 0; index < nameTextBox.Lines.Length; index++)
                {
                    if (nameTextBox.Lines[index].ToString() == selectedName)
                    {
                        sportsmen.RemoveAt(index);
                      
                    }
                }
                for (int i = 0; i < nameTextBox.Lines.Length; i++)
                {
                    nameTextBox.Text += $"[{i + 1}] { sportsmen[i].showInfo()}";
                }
            }
            else
                MessageBox.Show("Для начала введите количество спортсменов!");        
    }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Word Documents| *.doc|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
            Password input = new Password();
            if (input.ShowDialog() == DialogResult.OK)
                password = input.N;

            string newpassword = br.ReadString();
            if (String.Equals(password, newpassword))
            {
                N = br.ReadInt32();

                sportsmen = new List<Sportsman>();
                for (int i = 0; i < N; i++)
                {
                    sportsmen.Add(new Sportsman(seed++));
                    //sportsmen[i] = new Sportsman();
                    sportsmen[i] = sportsmen[i].Read(br);
                }

                ShowAll();
                br.Close();
                fs.Close();

                MessageBox.Show("File is opened");
            }
            else
            {
                MessageBox.Show("Пароль неверен");
                return;
            }
        }
        public void Write(BinaryWriter bw)
        {
            bw.Write(N);

            for (int i = 0; i < N; i++)
            {
                sportsmen[i].Write(bw);
            }
           
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if(n != 0)
            {
                if (password == null)
                {
                    MessageBox.Show("Добавьте пароль");
                    return;
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Word Documents| *.doc|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                //файловый поток
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                //бинарный записователь 
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(password);
                Write(bw);
                bw.Close();
                fs.Close();
                MessageBox.Show("File is saved");
            }
            else MessageBox.Show("Input quantity, please");
        }
        public void ShowAll()
        {
            infoTextBox.Text = "";
           
            for (int i = 0; i < N; i++)
            {
                infoTextBox.Text += "" + (i + 1) + "\n";
                infoTextBox.Text += sportsmen[i].showInfo();
                infoTextBox.Text += "******************************\n";
            }
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            Password input = new Password();
            if (input.ShowDialog() == DialogResult.OK)
            {
                password = input.N;
            }
            if(password!=null)
            MessageBox.Show("Пароль добавлен");
        }


    }
}
