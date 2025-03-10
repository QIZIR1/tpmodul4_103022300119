using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300119
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State state;

        public DoorMachine()
        {
            state = State.Terkunci;
        }

        public void KunciPintu()
        {
            if (state == State.Terkunci)
            {
                Console.WriteLine("Pintu sudah terkunci.");
            }
            else
            {
                state = State.Terkunci;
                Console.WriteLine("Pintu terkunci.");
            }
        }

        public void BukaPintu()
        {
            if (state == State.Terbuka)
            {
                Console.WriteLine("Pintu sudah terbuka.");
            }
            else
            {
                state = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci.");
            }
        }

        public void GetStatus()
        {
            Console.WriteLine("Status pintu: " + (state == State.Terkunci ? "Terkunci" : "Terbuka"));
        }
    }

}
