using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.classes
{
    class read
    {
        public List<String[]> listContest = new List<String[]>();
        public int leerArchivo()
        {
            

            string[] info = File.ReadAllLines(@"C: \Users\reyes\OneDrive\Documents\Tec de Monterrey\Semestre 3\Fundamentos de ingería de software\results.txt");
            int counter = 0;
            int minor = 0;
            foreach (string i in info)
            {
                string[] names = i.Split(' ');

                listContest.Add(names);
                if (int.Parse(listContest[counter][1]) < int.Parse(listContest[minor][1]))
                {
                    minor = counter;
                }

                counter++;
            }

            return minor;
        }
    }
}
