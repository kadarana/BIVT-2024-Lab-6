using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            // поля
            private string _name;
            private string _surname;
            private int[,] _marks;

            // свойства
            public string Name => _name;
            public string Surname => _surname;
            public int[,] Marks
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return null;
                    int[,] copy = new int[_marks.GetLength(0), _marks.GetLength(1)];
                    for (int i = 0; i < _marks.GetLength(0); i++)
                        for (int j = 0; j < _marks.GetLength(1); j++)
                            copy[i, j] = _marks[i, j];
                    return copy;
                }
            }
            // свойство 
            public int TotalScore
            {
                get
                {
                    
                    if (_marks == null) return 0;
                    int sum = 0;
                    for (int i = 0; i < _marks.GetLength(0); i++)
                        for (int j = 0; j < _marks.GetLength(1); j++)
                            sum += _marks[i, j];
                    return sum;
                }
            }
            // конструктор 
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
            }

            // метод
            public void Jump(int[] result)
            {
                if (result == null || _marks == null || result.Length < 5) return;
                int count1 = 0;
                int count2 = 0;
                for (int j = 0; j < 5; j++)
                {
                    count1 += _marks[0, j];
                    count2 += _marks[1, j];
                }
                if (count1 == 0)
                {
                    for (int j = 0; j < 5; j++)
                        _marks[0, j] = result[j];
                }
                else if (count2 == 0)
                {
                    for (int j = 0; j < 5; j++)
                        _marks[1, j] = result[j];
                }
                
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalScore < array[j + 1].TotalScore)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }

                    }
                }

            }
            public void Print()
            {
                Console.WriteLine($"Name: {_name}, Surname: {_surname}, Total score: {TotalScore}");
            }
        }

    }
}
