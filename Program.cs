using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_2;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check1();
        
            Check2();

            Check3();

            Check4();



            Check5();

        }

        static void Check1()
        {
            Blue_1.Response[] responses =
            {
                    new Blue_1.Response("Татьяна", "Степанова"),
                    new Blue_1.Response("Юрий", "Иванов"),
                    new Blue_1.Response("Марина", "Батова"),
                    new Blue_1.Response("Юрий", "Иванов"),
                };
            Blue_1.Response candidate1 = new Blue_1.Response("Татьяна", "Степанова");
            Blue_1.Response candidate2 = new Blue_1.Response("Юрий", "Иванов");
            Blue_1.Response candidate3 = new Blue_1.Response("Марина", "Батова");
            Blue_1.Response candidate4 = new Blue_1.Response("Юрий", "Иванов");

            candidate1.CountVotes(responses);
            candidate2.CountVotes(responses);
            candidate3.CountVotes(responses);
       

            candidate1.Print();
            candidate2.Print();
            candidate3.Print();
            Console.WriteLine();

        }

        static void Check2()
        {
            Blue_2.Participant[] participants =
            {
                    new Blue_2.Participant("Александр", "Петров"),
                    new Blue_2.Participant("Артем", "Луговой"),
                    new Blue_2.Participant("Мария", "Свиридова"),
            };
            participants[0].Jump(new int[] { 11, 0, 8, 7, 12 });
            participants[0].Jump(new int[] { 2, 3, 10, 13, 16 });

            participants[1].Jump(new int[] { 18, 17, 20, 7, 11 });
            participants[1].Jump(new int[] { 3, 7, 12, 19, 2 });

            participants[2].Jump(new int[] { 2, 17, 5, 11, 3 });
            participants[2].Jump(new int[] { 7, 18, 3, 5, 3 });

            Participant.Sort(participants);

            foreach (var participant in participants)
            {
                participant.Print();
            }
            Console.WriteLine();
        }

        static void Check3()
        { 
            Blue_3.Participant participant1 = new Blue_3.Participant("Инна", "Пономарева");
            participant1.PlayMatch(2);
            participant1.PlayMatch(2);
            participant1.PlayMatch(0);
            participant1.PlayMatch(2);
            participant1.PlayMatch(0);
            participant1.PlayMatch(0);
            participant1.PlayMatch(5);
            participant1.PlayMatch(2);
            participant1.PlayMatch(5);

            Blue_3.Participant participant2 = new Blue_3.Participant("Юрий", "Ушаков");
            participant2.PlayMatch(0);
            participant2.PlayMatch(10);
            participant2.PlayMatch(10);
            participant2.PlayMatch(0);
            participant2.PlayMatch(5);
            participant2.PlayMatch(5);
            participant2.PlayMatch(2);
            participant2.PlayMatch(10);
            participant2.PlayMatch(10);
            participant2.PlayMatch(10);

            Blue_3.Participant participant3 = new Blue_3.Participant("Дмитрий", "Иванов");
            participant3.PlayMatch(2);
            participant3.PlayMatch(5);
            participant3.PlayMatch(5);
            participant3.PlayMatch(2);
            participant3.PlayMatch(0);
            participant3.PlayMatch(10);
            participant3.PlayMatch(5);
            participant3.PlayMatch(2);
            participant3.PlayMatch(0);
            participant3.PlayMatch(0);

           
            Blue_3.Participant[] participants = { participant1, participant2, participant3 };

           
            Blue_3.Participant.Sort(participants);

         
            foreach (var participant in participants)
            {
                participant.Print();
            }
            Console.WriteLine();
        }

        static void Check4()
        {
            Blue_4.Team[] teams = new Blue_4.Team[]            {
                   new Blue_4.Team("Энергия"),
                   new Blue_4.Team("Спартак"),
                   new Blue_4.Team("Барс"),
                   new Blue_4.Team("Нефтехим"),
                   new Blue_4.Team("Байкал"),
                   new Blue_4.Team("Василек"),
                   new Blue_4.Team("Урал"),
                   new Blue_4.Team("Быки"),
                   new Blue_4.Team("Метеор"),
                   new Blue_4.Team("Быки"),
                   new Blue_4.Team("ЦСКА"),
                   new Blue_4.Team("Русь")            };
            foreach (var x in new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 }) teams[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 }) teams[1].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 }) teams[2].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 }) teams[3].PlayMatch(x);
            foreach (var x in new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 }) teams[4].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 }) teams[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 }) teams[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teams[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teams[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teams[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[10].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[11].PlayMatch(x);
            Blue_4.Group group1 = new Blue_4.Group("Группа 1");
            foreach (var team in teams)
            {
                group1.Add(team);
            }
            group1.Sort();
            Console.WriteLine("Группа 1 после сортировки:"); group1.Print();

            Console.WriteLine();
            Blue_4.Team[] teamss = new Blue_4.Team[] {
            new Blue_4.Team("Локомотив"),
            new Blue_4.Team("СКА"),
            new Blue_4.Team("Энергия"),
            new Blue_4.Team("Нефтехим"),
            new Blue_4.Team("Ак-барс"),
            new Blue_4.Team("Барс"),
            new Blue_4.Team("СПБ"),
            new Blue_4.Team("Быки"),
            new Blue_4.Team("Метеор"),
            new Blue_4.Team("Быки"),
            new Blue_4.Team("ЦСКА"),
            new Blue_4.Team("Русь") };

            foreach (var x in new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 }) teamss[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 }) teamss[1].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 }) teamss[2].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 }) teamss[3].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 }) teamss[4].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 }) teamss[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 }) teamss[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teamss[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teamss[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teamss[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teamss[10].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) teamss[11].PlayMatch(x);
            Blue_4.Group group2 = new Blue_4.Group("Группа 2");
            foreach (var team in teamss)
            {
                group2.Add(team);
            }
            group2.Sort();
            Console.WriteLine("Группа 2 после сортировки:"); group2.Print();
            Blue_4.Group.Merge(group1, group2, 12).Print();
        }


        static void Check5()
        {
            Blue_5.Sportsman[] Sportsmen = new Blue_5.Sportsman[]
                 {
                 new Blue_5.Sportsman("Мирослав", "Распутин"),
                 new Blue_5.Sportsman("Игорь", "Павлов"),
                 new Blue_5.Sportsman("Полина", "Свиридова"),
                 new Blue_5.Sportsman("Савелий", "Луговой"),
                 new Blue_5.Sportsman("Николай", "Козлов"),
                 new Blue_5.Sportsman("Юлия", "Сидорова"),
                 new Blue_5.Sportsman("Полина", "Луговая"),
                 new Blue_5.Sportsman("Светлана", "Иванова"),
                 new Blue_5.Sportsman("Александр", "Петров"),
                 new Blue_5.Sportsman("Игорь", "Распутин"),
                 new Blue_5.Sportsman("Савелий", "Свиридов"),
                 new Blue_5.Sportsman("Мария", "Свиридова"),
                 new Blue_5.Sportsman("Дмитрий", "Свиридов"),
                 new Blue_5.Sportsman("Светлана", "Козлова"),
                 new Blue_5.Sportsman("Екатерина", "Луговая"),
                 new Blue_5.Sportsman("Степан", "Жарков"),
                 new Blue_5.Sportsman("Степан", "Распутин"),
                 new Blue_5.Sportsman("Дарья", "Свиридова") };
            int[] places = { 12, 2, 17, 13, 5, 6, 7, 8, 9, 10, 11, 1, 4, 14, 15, 16, 3, 18 };
            for (int i = 0; i < Sportsmen.Length; i++)
            {
                Sportsmen[i].SetPlace(places[i]);
            }

            Blue_5.Team[] teams = new Blue_5.Team[]
            {
                     new Blue_5.Team("Локомотив"),
                     new Blue_5.Team("Динамо"),
                     new Blue_5.Team("Спартак") };

            teams[0].Add(new Blue_5.Sportsman[] { Sportsmen[0], Sportsmen[1], Sportsmen[2], Sportsmen[3], Sportsmen[4], Sportsmen[5] });
            teams[1].Add(new Blue_5.Sportsman[] { Sportsmen[6], Sportsmen[7], Sportsmen[8], Sportsmen[9], Sportsmen[10], Sportsmen[11] });
            teams[2].Add(new Blue_5.Sportsman[] { Sportsmen[12], Sportsmen[13], Sportsmen[14], Sportsmen[15], Sportsmen[16], Sportsmen[17] });

            Blue_5.Team.Sort(teams);

            Console.WriteLine("Результаты соревнований:");
            foreach (var team in teams)
            {
                Console.WriteLine($"Команда: {team.Name}, Очки: {team.SummaryScore}, Лучший результат: {team.TopPlace}");
                team.Print();
            }

        }
    }


    
}
