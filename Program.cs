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
            
            // на чек4 и чек5 я сдалась

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
    }
}
