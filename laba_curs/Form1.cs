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
        public int k;
        string password;
        List<string> countries = new List<string> { "Украина", "США", "Германия", "Англия", "Франция", "Испания", "Китай" };
        List<string> names = new List<string> { "Джексон", "Ковальски", "Поттер", "Романенко", "Смит", "Старк", "Уайт" };

        public int N { get => n; set => n = value; }
        int seed = 0;
        public Form1()
        {
            InitializeComponent();

        }
        public void UpdateListBox()
        {
            countryListBox.Items.Clear();
            for (int i = 0; i < countries.Count; i++)
            {
                countryListBox.Items.Add(countries[i]);
            }
            countryListBox.SelectedIndexChanged += countryListBox_SelectedIndexChanged;
            typeListBox.Items.Clear();
            string[] sports = { "Горнолыжный спорт", "Лыжные гонки", "Прыжки с трамплина", "Лыжное двоеборье", "Фристайл", "Сноуборд", "Биатлон", "Фигурное катание", "Конькобежный спорт", "Шорт-трек", "Бобслей", "Санный спорт", "Кёрлинг" };
            typeListBox.Items.AddRange(sports);
            typeListBox.SelectedIndexChanged += typeListBox_SelectedIndexChanged;
            nameListBox.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                nameListBox.Items.Add(names[i]);
            }
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
                sportsmen[i].setInfo();                
                nameTextBox.Text += $"[{i + 1}] { sportsmen[i].showInfo()}";
            }
            UpdateListBox();
        }

        private void countryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (n != 0)
            {
                infoTextBox.Clear();
                string selectedCountry = countryListBox.SelectedItem.ToString();
                MessageBox.Show("Вы выбрали " + selectedCountry);
                for (int index = 0; index < sportsmen.Count; index++)
                {
                    if (sportsmen[index].sportsmen.country == selectedCountry)
                    {
                        infoTextBox.Text += $"[{index + 1}] {sportsmen[index].showInfo()}";

                        //infoTextBox.Text += $"{sportsmen[index].sportsmen.ToString()}\n";
                    }
                }
                if (infoTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Данная страна не участвовала в Олимпиаде");
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
                nameTextBox.Clear();

                string selectedName = nameListBox.SelectedItem.ToString();
                MessageBox.Show("Вы выбрали " + selectedName);

                for (int index = 0; index < sportsmen.Count; index++)
                {
                    if (sportsmen[index].sportsmen.F.Equals(selectedName))
                    {
                        sportsmen.RemoveAt(index);
                    }
                }
                ShowAll();
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
            if (n != 0)
            {
                if (password == null)
                {
                    MessageBox.Show("Добавьте пароль!");
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
            nameTextBox.Text = "";

            for (int i = 0; i < sportsmen.Count; i++)
            {
                nameTextBox.Text += $"[{i + 1}] {sportsmen[i].showInfo()}\n";
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
            if (password != null)
                MessageBox.Show("Пароль добавлен");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            infoTextBox.Clear();
            for (int i = 0; i < countries.Count; i++)
            {
                int first = 0;
                int second = 0;
                int third = 0;
                for (int j = 0; j < sportsmen.Count; j++)
                {
                    if (sportsmen[j].sportsmen.country.Equals(countries[i]))
                    {
                        if (sportsmen[j].sportsmen.place == 1) first++;
                        if (sportsmen[j].sportsmen.place == 2) second++;
                        if (sportsmen[j].sportsmen.place == 3) third++;
                    }
                }
                infoTextBox.Text += $"{countries[i]}\nзолото:{first}\nсеребро:{second}\nбронза:{third}\n\n";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            k = -1;
            int j = 0;
            AddObj form = new AddObj();
            if (form.ShowDialog() == DialogResult.OK)
            {
                sportsmen.Add(form.sportsman);
                for (int i = 0; i < countries.Count; i++)
                {
                    if (countries[i] == form.sportsman.sportsmen.country)
                    {
                        j++;
                    }
                }
                if (j == 0)
                {
                    countries.Add(form.sportsman.sportsmen.country);
                }
                j = 0;
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i] == form.sportsman.sportsmen.F)
                    {
                        j++;

                    }
                }
                if (j == 0)
                {
                    names.Add(form.sportsman.sportsmen.F);
                }
            }
            UpdateListBox();
            ShowAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = false;
            int j = 0;
            k = 0;
            if (sportsmen.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            EditByNum form = new EditByNum();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < sportsmen.Count; i++)
                {
                    if (i + 1 == form.number)
                    {
                        result = true;
                        k = i;
                        AddObj f = new AddObj();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            sportsmen[i] = f.sportsman;
                            for (int l = 0; l < countries.Count; l++)
                            {
                                if (countries[l] == f.sportsman.sportsmen.country)
                                {
                                    j++;
                                }
                            }
                            if (j == 0)
                            {
                                countries.Add(f.sportsman.sportsmen.country);
                            }
                            j = 0;
                            for (int l = 0; l < names.Count; l++)
                            {
                                if (names[l] == f.sportsman.sportsmen.F)
                                {
                                    j++;
                                }
                            }
                            if (j == 0)
                            {
                                names.Add(f.sportsman.sportsmen.F);
                            }
                        }
                    }
                    sportsmen[i].showInfo();
                }

                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }


            }
            UpdateListBox();
            ShowAll();
        }
    }
}
