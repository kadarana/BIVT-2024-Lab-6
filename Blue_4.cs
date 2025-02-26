using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6

{
    public class Blue_4
    {
        public struct Team
        {
            private string _name;
            private int[] _scores; // массив очков, полученных за матчи 

            public string Name => _name;
            public int[] Scores
            {
                get
                {
                    if (_scores == null) return default(int[]);
                    int[] copy = new int[_scores.Length];
                    Array.Copy(_scores, copy, _scores.Length);
                    return copy;
                }
            }


            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    return _scores.Sum();
                }
            }

            public Team(string name)
            {
                _name = name;
                _scores = new int[0];

            }

            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                Array.Resize(ref _scores, _scores.Length + 1);
                _scores[_scores.Length - 1] = result;
            }

            public void Print()
            {
                Console.Write($"Team: {_name}, TotalScore: {TotalScore}");
                Console.WriteLine();
            }
        }



        public struct Group
        {
            private string _name;
            private Team[] _teams;
            private int _currentIndex;

            public string Name => _name;
            public Team[] Teams => _teams;


            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _currentIndex = 0;
            }

            public void Add(Team team)
            {
                if (_teams == null || _currentIndex >= _teams.Length) return;
                _teams[_currentIndex++] = team;



            }
            public void Add(Team[] teams)
            {
                if (teams == null) return;
                foreach (var team in teams)
                {
                    Add(team);
                }

            }
            public void Sort()
            {
                if (_teams == null) return;
                // гномья эффективная сортировка 
                for (int i = 1, j = 2; i < _teams.Length;)
                {
                    if (i == 0 || _teams[i].TotalScore <= _teams[i - 1].TotalScore)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        (_teams[i], _teams[i - 1]) = (_teams[i - 1], _teams[i]);
                        i--;
                    }

                }
            }

            public static Group Merge(Group group1, Group group2, int size)
            {
                if (size <= 0) return default(Group);
                Group finalGroup = new Group("Финалисты");
                int mergedGroup = 6; // количество лучших команд из каждой группы
                int i = 0, j = 0;
                while (i < mergedGroup && j < mergedGroup)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        finalGroup.Add(group1.Teams[i]);
                        i++;
                    }
                    else
                    {
                        finalGroup.Add(group2.Teams[j]);
                        j++;
                    }

                }

                while (i < mergedGroup)
                {
                    finalGroup.Add(group1.Teams[i]);
                    i++;
                }

                while (j < mergedGroup)
                {
                    finalGroup.Add(group2.Teams[j]);
                    j++;
                }

                return finalGroup;

            }
            public void Print()
            {
                Console.WriteLine(_name);
                foreach (var team in _teams)
                {

                    team.Print();
                }
            }

        }
    }
}