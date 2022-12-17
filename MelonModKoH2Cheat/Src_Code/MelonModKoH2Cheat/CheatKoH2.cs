using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MelonLoader;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using System.Diagnostics;

namespace MelonModKoH2Cheat
{
    public class CheatKoH2_Init : MelonMod //Mod for Melon :D
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F4))
            {
                KoH2_Cheat k = new KoH2_Cheat();
                k.Autosave();
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                KoH2_Cheat k = new KoH2_Cheat();
                k.SetFoV(75);
            }
            if (Input.GetKeyDown(KeyCode.F5)) 
            {
                KoH2_Cheat k = new KoH2_Cheat();
                k.ThirdLevelCheat();
                k.EnableDevMode();
            }
            if (Input.GetKeyDown(KeyCode.F10))
            {
                Directory.CreateDirectory(@"C:\Temp");
                File.WriteAllText(@"C:\Temp\README.txt", "Thank you for Choosing This Mod... Made by RyuzakiEverywhere");
                Process.Start("notepad", @"C:\Temp\README.txt");
            }
            if (Input.GetKeyDown(KeyCode.F12))
            {
                Application.Quit();
            }
        }
    }
}
