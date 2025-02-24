using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            private string _name;
            private string _surname;
            private int _place;

            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;

            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }

            public void SetPlace(int place)
            {
                if (_place > 0) return;
                _place = place;
            }

            public void Print()
            {
                Console.WriteLine($"Name: {_name}, Surname: {_surname}, Place: {_place}");
            }


        }

        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsmen;

            public string Name => _name;
            public Sportsman[] Sportsmen
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return null;
                    Sportsman[] copy = new Sportsman[_sportsmen.Length];
                    Array.Copy(_sportsmen, copy, _sportsmen.Length);
                    return copy;
                }
            }
            public int SummaryScore
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return 0;
                    int sum = 0;
                    for(int i = 0; i < _sportsmen.Length; i++)
                    {
                      switch (_sportsmen[i].Place)
                        {
                            case 1:
                                sum += 5;
                                break;
                            case 2:
                                sum += 4;
                                break;
                            case 3:
                                sum += 3;
                                break;
                            case 4:
                                sum += 2;
                                break;
                            case 5:
                                sum += 1;
                                break;
                            default:
                                sum += 0;
                                break;

                        }
                    }
                    return sum;

                }
            }
            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return 0;
                    int min = int.MaxValue;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                         if (_sportsmen[i].Place < min) min = _sportsmen[i].Place;
                    }
                    return min;
                }
            }
            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[0];
            }
            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _sportsmen.Length == 0) return;
                Array.Resize(ref _sportsmen, _sportsmen.Length + 1);
                _sportsmen[_sportsmen.Length - 1] = sportsman;

            }
            public void Add(Sportsman[] sportsmen)
            {
                if (sportsmen == null || sportsmen.Length == 0) return;
                foreach (var sportsman in sportsmen)
                    Add(sportsman);
            }

            public static void Sort(Team[] teams)
            {
                if (teams == null || teams.Length == 0) return;

                for (int i = 0; i  < teams.Length; i++)
                {
                    for (int j = 0; j < teams.Length - i - 1; j++)
                    {
                        if (teams[j].SummaryScore > teams[j + 1].SummaryScore)

                            (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]);


                        else if (teams[j].SummaryScore == teams[j + 1].SummaryScore && teams[j].TopPlace > teams[j + 1].TopPlace)

                            (teams[j], teams[j + 1]) = (teams[j], teams[j + 1]);
                    }
                }

            }
            public void Print()
            {
                Console.WriteLine($"Name: {_name}, Summary score: {SummaryScore}, Top Place: {TopPlace}");
                foreach (var sportsman in _sportsmen)
                {
                    sportsman.Print();
                }
                Console.WriteLine();
                
            }

        }
    }
}
