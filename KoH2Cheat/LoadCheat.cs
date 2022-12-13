using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KoH2Cheat
{
    public class LoadCheat
    {
        public static GameObject game;
        public static void LoadKoH2Cheat()
        {
            LoadCheat.game = new GameObject();
            LoadCheat.game.AddComponent<CheatInit>();
            UnityEngine.Object.DontDestroyOnLoad(game);
        }
        public static void UnloadKoH2Cheat()
        {
            GameObject.Destroy(game); //Destroying Module :D
        }
    }
}
