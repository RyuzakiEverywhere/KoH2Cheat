using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace MelonModKoH2Cheat
{
    public class KoH2_Cheat
    {
        public static GameObject game_obj;
        public static DevCheats dev;
        public static GameLogic game;
        public void Autosave()
        {
          dev = game_obj.GetComponent<DevCheats>();
          dev.Autosave(); //Autosaving :D
        }
        public bool EnableDevMode() //Make You Enable Third Level of Cheat Mode :D
        {
            bool enabled = true;
            if (enabled)
            {
                dev = game_obj.GetComponent<DevCheats>();
                GameLogic.developer_console_enabled = true;
                return true;
            }
            else
            {
                return dev.gameObject.isStatic; //Returning If GameObject Is Static :D
            }
        }
        public void ThirdLevelCheat()
        {
            dev = game_obj.GetComponent<DevCheats>();
            GameLogic.instance.logic.SetCheatLevel(Logic.Game.CheatLevel.High);
        }
        public void SetFoV(int fov)
        {
            dev = game_obj.GetComponent<DevCheats>();
            dev.SetFoV(fov); //FoV :D
        }
        public bool AddBook(int book)
        {
            GameLogic game = game_obj.GetComponent<GameLogic>();
            DevCheats ch = game_obj.GetComponent<DevCheats>();
            ch.enabled = true;
            ch.AddBookBundle(book);
            return true;
        }
    }
}
