using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{ class Social
    {
        List<string> social = new List <string>();


        public void Add(string start_1)
        {
            social.Add(start_1);

        }
        public void Remove(string Fun)
        {
            social.Remove(Fun);
            Console.WriteLine("Deleted");
        }
        public string GetById(int id)
        {
            return "Элемент с id "+ id+" "+ social[id];
        }
        public void Insert(int id, string Fun)
        {
            social.Insert(id, Fun);

        }
        public void Update(int id, string Fun)
        {
            social.RemoveRange(id, 1);
            social.Insert(id, Fun); 
        }
        public string Find1(int Fun, int condition)
        {
           if( social.Exists( Fun => Fun.Length == condition))// проверяю есть ли элемент с заданным условием длинны
            {
                return social.Find(Fun => Fun.Length == condition);
            }
            else
            {
                return "Имени нет в списке";
            }

        }
public void GetAll()
        {
            foreach(string Fun in social)
            {
                Console.WriteLine(Fun);
            }
        }
    }
}

