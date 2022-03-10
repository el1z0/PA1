using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();

            string[] m =
            {
                "5",
                "1",
                "5",
            };
            Console.WriteLine(cls.MinAVG(m));

            List<Mark> marks = new List<Mark>();

            marks.Add(new Mark
            {
                date = DateTime.Parse("20.02.2022"),
                Estimation = "п",
            });
            marks.Add(new Mark
            {
                date = DateTime.Parse("22.02.2022"),
                Estimation = "п",
            });
            marks.Add(new Mark
            {
                date = DateTime.Parse("22.02.2022"),
                Estimation = "б",
            });
            marks.Add(new Mark
            {
                date = DateTime.Parse("22.02.2022"),
                Estimation = "п",
            });

            int[] cc = cls.GetCountTruancy(marks);
            for (int i = 0; i < cc.Length; i++)
            {
                Console.WriteLine(cc[i]);
            }

            int[] cd = cls.GetCountDisease(marks);
            for (int i = 0; i < cd.Length; i++)
            {
                Console.WriteLine(cd[i]);
            }

            string numb = cls.GetStudNumber(2018, 1281, "Ткаченко Елизавета Сергеевна");
            Console.WriteLine(numb);

            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Group = "1281",
                YearAdmission = 2018,
                FIO = "Ткаченко Елизавета Сергеевна",
            });

            var getmarks = cls.GetMarks(DateTime.Now, students);
            for (int i = 0; i < getmarks.Count(); i++)
            {
                foreach (var item in getmarks.ElementAt(i).Marks)
                {
                    Console.WriteLine(item.Estimation);
                }
                
            }
            Console.ReadKey();
        }
    }
}
