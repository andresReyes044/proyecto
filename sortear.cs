using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.classes;

namespace ConsoleApp7.classes
{
    class sortear
    {
        public void sort()
        {
            read r = new read();

            int minor = r.leerArchivo();
            int firstPlace = minor;
            int secondPlace = minor;
            int thirdPlace = minor;

            for (int i = 0; i < r.listContest.Count; i++)
            {
                if (int.Parse(r.listContest[firstPlace][1]) < int.Parse(r.listContest[i][1]))
                {
                    thirdPlace = secondPlace;
                    secondPlace = firstPlace;
                    firstPlace = i;
                }
                else if (int.Parse(r.listContest[secondPlace][1]) < int.Parse(r.listContest[i][1]))
                {
                    thirdPlace = secondPlace;
                    secondPlace = i;
                }
                else if (int.Parse(r.listContest[thirdPlace][1]) < int.Parse(r.listContest[i][1]))
                {
                    thirdPlace = i;
                  
                }
            }
            Console.WriteLine("El primer lugar con iphone es para " + r.listContest[firstPlace][0] + " con " + r.listContest[firstPlace][1]);
            Console.WriteLine("segundo lugar con una despensa es para " + r.listContest[secondPlace][0] + " con " + r.listContest[secondPlace][1]);
            Console.WriteLine("tercer lugar pero sin nada es para " + r.listContest[thirdPlace][0] + " con " + r.listContest[thirdPlace][1]);
            ganadores g = new ganadores();
            g.wins(firstPlace, secondPlace, thirdPlace);
            Console.ReadKey();
        }
    }
}
