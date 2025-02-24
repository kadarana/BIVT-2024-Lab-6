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
            private int[] _penaltyTimes;


            public string Name => _name;
            public string Surname => _surname;

            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return null;
                    int[] copy = new int[_penaltyTimes.Length];
                    Array.Copy(_penaltyTimes, copy, _penaltyTimes.Length);
                    return copy;
                }
            }

            public int TotalTime
            {
                get

                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return 0;

                    else
                        return _penaltyTimes.Sum();
                }
            }
            

            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return false;
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) return true; 
                    }
                    return false;
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[0];
                
            }


            public void PlayMatch(int time)
            {
                if (_penaltyTimes == null || _penaltyTimes.Length == 0) return;
                // добавляет в массив штрафов штрафное время
                Array.Resize(ref _penaltyTimes, _penaltyTimes.Length + 1);
                _penaltyTimes[_penaltyTimes.Length - 1] = time;
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) { return; }
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
