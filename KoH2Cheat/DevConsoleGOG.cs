using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoH2Cheat;
using UnityEngine;

namespace KoH2Cheat.DevMode //DevMode :D
{
    public class DevConsoleGOG //Enabling DevConsole :D
    {
        public static LoadCheat load;
        public static GameObject game_obj;
        public bool disabled = false;
        public bool enabled = true;
        public void EnableDevConsole()
        {
            if (disabled)
            {
                GameLogic game_l = game_obj.GetComponent<GameLogic>();
                GameLogic.developer_console_enabled = true;
            }
        }
        public void DisableDevConsole()
        {
            if (enabled)
            {
                GameLogic game_logic = game_obj.GetComponent<GameLogic>(); //Getting Component for Init Cheat :D
                GameLogic.developer_console_enabled = false;
            }
        }
    }
}
