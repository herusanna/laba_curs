using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_curs
{
    public struct sportsman
    {
        public string country;
        public string type;
        public int place;
        public string F;
        public string I;
        public string O;
    };
    public class Sportsman
    {
        //List<string> listOfI = new List<string>()
        //{ "Роберт","Эмма","Питер","Наталья","Иван","Алиса","Кирилл"};
        public List<string> sports = new List<string> { "Горнолыжный спорт", "Лыжные гонки", "Прыжки с трамплина", "Лыжное двоеборье", "Фристайл", "Сноуборд", "Биатлон", "Фигурное катание", "Конькобежный спорт", "Шорт-трек", "Бобслей", "Санный спорт", "Хоккей с шайбой", "Кёрлинг" };
        public List<string> f = new List<string> { "Старк", "Смит", "Уайт", "Романенко", "Джексон", "Поттер", "Ковальски" };
        Random r;
        public sportsman sportsmen = new sportsman();
        //public int place;
        public Sportsman(){}
        //static Random random = new Random(DateTime.Now.Millisecond);
        public Sportsman(int seed) { 
             r = new Random(seed);

            var i = new List<string> {"Роберт", "Эмма", "Питер","Наталья", "Иван", "Алиса", "Кирилл" };
            while (i.Count > 0)
            {
                int index = r.Next(0, i.Count);
                sportsmen.I = i[index];
                Random a = new Random(seed);
                i.RemoveAt(index);
            }
            var o = new List<string> { "Тони", "Джонсон", "Нико", "Уайтлоу", "Шарлотт", "Кьяра", "Павлович" };
            while (o.Count > 0)
            {
                int index = r.Next(0, o.Count);
                sportsmen.O = o[index];
                o.RemoveAt(index);
            }
           
        }
       
        public string setF()
        {
            //Random r = new Random(DateTime.Now.ToString().GetHashCode());
           
            while (f.Count > 0)
            {
                int index = r.Next(0, f.Count);
                sportsmen.F = f[index];
                f.RemoveAt(index);
            }
            return sportsmen.F;
        }
        public string setCountry()
        {
           // Random r = new Random(DateTime.Now.ToString().GetHashCode());
            var country = new List<string> { "Украина", "США", "Германия", "Англия", "Франция", "Испания", "Китай" };
            while (country.Count > 0)
            {
                int index = r.Next(0, country.Count);
                sportsmen.country = country[index];
                country.RemoveAt(index);
            }
            return sportsmen.country;
        }
       
        public string setType()
        {
            //  Random r = new Random();
            while (sports.Count > 0)
            {
                int index = r.Next(0, sports.Count);
                sportsmen.type = sports[index];
                sports.RemoveAt(index);

            }
            return sportsmen.type;
        }
        public int setPlace()
        {                        
            return sportsmen.place = r.Next(1, 4);
        }
        public string showName()
        {
            string info = "";
            info += $"{sportsmen.F}   ";
            info += $"{sportsmen.I}   ";
            info += $"{sportsmen.O}\n";
            return info;
        }
        public void setInfo()
        {
            setF();
            setCountry();
            setType();
            setPlace();
        }
        public string showInfo()
        {
            string info = "";
            info += $"{sportsmen.F}  ";
            info += $"{sportsmen.I}  ";
            info += $"{sportsmen.O}\n";
            info += $"{sportsmen.country}\n";            
            info += $"{sportsmen.type}\n";
            info += $"{sportsmen.place} место\n ";
            info += "---------------------------\n\n";
            return info;
        }
        public void Write(BinaryWriter bw)
        {
            setF();
            bw.Write(sportsmen.F);
            bw.Write(sportsmen.I);
            bw.Write(sportsmen.O);
            setCountry();
            bw.Write(sportsmen.country);
            setType();         
                bw.Write(sportsmen.type);
            bw.Write(sportsmen.place);
            //bw.Write(sportsmen.place);
        }
        public Sportsman Read(BinaryReader br)
        {
            Sportsman temp = new Sportsman();
            setF();
            temp.sportsmen.F = br.ReadString();
            temp.sportsmen.I = br.ReadString();
            temp.sportsmen.O = br.ReadString();
            setCountry();
            temp.sportsmen.country = br.ReadString();
            setType();
            temp.sportsmen.type = br.ReadString();
            temp.sportsmen.place = br.Read();
            return temp;
        }
    }
}
