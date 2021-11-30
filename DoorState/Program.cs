using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorState
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool Check_If_Door_Can_Be_Changed(Door door)
        {
            if(door.State == "Open")
            {

            }
            string guid = Guid.NewGuid().ToString();
            Door puerta = new Door("Hola");
            return true;
        }
    }
}
