using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorState
{
    public class Door
    {
        public string State;
        public Door(string state)
        {
            State = state;
        }

        public static Door Open_And_Unlocked(Guid guid)
        {
            Door door = new Door("Open and Unlocked");
            return door;
        }

        public static Door Open_And_Locked(Guid guid)
        {
            Door door = new Door("Open and Locked");
            return door;
        }

        public static Door Closed_And_Unlocked(Guid guid)
        {
            Door door = new Door("Closed and Unlocked");
            return door;
        }

        public static Door Closed_And_Locked(Guid guid)
        {
            Door door = new Door("Closed and Locked");
            return door;
        }

        public static bool Open_Door(Door door)
        {
            if((door.State=="Open and Unlocked") || (door.State=="Closed and Unlocked"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
