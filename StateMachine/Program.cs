using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class Program
    {
        enum State
        {
            patrolling,
            chasing,
            searching,
            attacking,
            retreating
        }

        static State state;

        static void Main(string[] args)
        {
            Console.WriteLine("State Machine");
            Console.WriteLine("");
            Console.WriteLine();

            state = State.patrolling;
            EnemyUpdate();
            EnemyUpdate();
            EnemyUpdate();
            EnemyUpdate();
            EnemyUpdate();

            Console.WriteLine();
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey(true);
        }

        static void EnemyUpdate()
        {
            switch (state)
            {
                case State.patrolling:
                    Console.WriteLine("Patrolling... and potentially switching to chasing.");
                    state = State.chasing;
                    break;

                case State.chasing:
                    Console.WriteLine("Chasing... and potentially switching to attacking.");
                    state = State.attacking;
                    break;

                case State.searching:
                    Console.WriteLine("Searching... and potentially switching to chasing.");
                    state = State.chasing;
                    break;

                case State.attacking:
                    Console.WriteLine("Attacking... and potentially switching to retreating.");
                    state = State.retreating;
                    break;

                case State.retreating:
                    Console.WriteLine("Retreating... and potentially switching to patrolling.");
                    state = State.patrolling;
                    break;
            }
        }
    }
}
