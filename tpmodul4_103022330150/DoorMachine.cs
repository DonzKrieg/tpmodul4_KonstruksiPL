using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022330150
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState = State.Terkunci;

        public void Lock()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void Unlock()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

    }
}
