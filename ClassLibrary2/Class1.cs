using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public double MinAVG(string[] marks)
        {
            return Math.Floor(marks.Select(s => double.Parse(s)).Average());
        }

        public int[] GetCountTruancy(List<Mark> marks)
        {
            int[] countT = marks.GroupBy(g => g.date.Month)
                .Select(s => s.Count(c => c.Estimation.ToLower() == "п")).ToArray();
            return countT;
        }

        public int[] GetCountDisease(List<Mark> marks)
        {
            int[] countD = marks.GroupBy(g => g.date.Month)
                .Select(s => s.Count(c => c.Estimation.ToLower() == "б")).ToArray();
            return countD;
        }

        public string GetStudNumber(int year, int group, string fio)
        {
            string[] initial = fio.Split(' ');
            string studNumber = $"{year}.{group}.{initial[0][0]}{initial[1][0]}{initial[2][0]}";
            return studNumber;
        }

        public List<Student> GetMarks(DateTime now, List<Student> students)
        {
            foreach (var item in students)
            {
               
                Random random = new Random();
                string[] marks =
                {
                    "2",
                    "3",
                    "4",
                    "5"
                };
                item.Marks = new List<Mark>();
                for (int i = 0; i < 10; i++)
                {
                    item.Marks.Add(new Mark { date = now.AddDays(1), Estimation = marks[random.Next(1, marks.Length)].ToString()});
                }
            }
            return students;
        }
    }
}
