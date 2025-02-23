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
                    if (_scores == null || _scores.Length == 0) return default(int[]);
                    int[] copy = new int[_scores.Length];
                    Array.Copy(_scores, copy, _scores.Length);
                    return copy;
                }
            }

            public int TotalScore => _scores.Sum();
            
            public Team(string name)
            {
                _name = name;
                _scores = new int[0];
            }

            public void PlayMatch(int result)
            {
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

            public string Name => _name;
            public Team[] Teams
            {
                get
                {
                    if (_teams == null || _teams.Length == 0) return default(Team[]);
                    Team[] copy = new Team[_teams.Length];
                    Array.Copy(_teams, copy, _teams.Length);
                    return copy;
                }
            }

            public Group(string name)
            {
                _name = name;
                _teams = new Team[0];
            }

            public void Add(Team team)
            {
                
                if (_teams.Length < 12)
                {
                    Array.Resize(ref _teams, _teams.Length + 1);
                    _teams[_teams.Length - 1] = team;
                }

            }
            public void Add(Team[] teams)
            {
                if (teams == null || teams.Length == 0) return;
                foreach (var team in teams)
                {
                    Add(team);
                }

            }
            public void Sort()
            {
                if (_teams == null || _teams.Length == 0) return;
                for (int i = 1, j = 2; i < _teams.Length; i++)
                {
                    if (i == 0 || _teams[i].TotalScore > _teams[i - 1].TotalScore)
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
                Group finalGroup = new Group("Финалисты");
                int mergedGroup = size / 2;
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
