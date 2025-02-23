using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int[] _penaltyTime;


            public string Name => _name;
            public string Surname => _surname;

            public int[] PenaltyTime
            {
                get
                {
                    if (_penaltyTime == null || _penaltyTime.Length == 0) return null;
                    int[] copy = new int[_penaltyTime.Length];
                    Array.Copy(_penaltyTime, copy, _penaltyTime.Length);
                    return copy;
                }
            }

            public int TotalTime
            {
                get

                {
                    if (_penaltyTime == null || _penaltyTime.Length == 0) return 0;

                    else
                        return _penaltyTime.Sum();
                }
            }
            

            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTime == null || _penaltyTime.Length == 0) return false;
                    for (int i = 0; i < _penaltyTime.Length; i++)
                    {
                        if (_penaltyTime[i] == 10) return true; 
                    }
                    return false;
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTime = new int[0];
                
            }


            public void PlayMatch(int time)
            {
                // добавляет в массив штрафов штрафное время
                Array.Resize(ref _penaltyTime, _penaltyTime.Length + 1);
                _penaltyTime[_penaltyTime.Length - 1] = time;
            }

            public static void Sort(Participant[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime)
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }

            }

            public void Print()
            {
                Console.Write($"Name: { _name}, Surname: { _surname}, Total time: {TotalTime}, is Expelled: {IsExpelled}");
                Console.WriteLine();
            }
        }

    }
}
