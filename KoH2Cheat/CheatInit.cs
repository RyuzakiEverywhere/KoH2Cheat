using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using KoH2Cheat.DevMode;
using System.IO;

namespace KoH2Cheat
{
    public class CheatInit : MonoBehaviour
    {
        GameLogic game = FindObjectOfType<GameLogic>();
        DevCheats dev = FindObjectOfType<DevCheats>();
        Kingdom kingdom = new Kingdom();
        DevMode.DevConsoleGOG gog = new DevConsoleGOG();

        public void Start()
        {

        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                gog.EnableDevConsole();
            }
            if(Input.GetKeyDown(KeyCode.F6))
            {
                gog.DisableDevConsole();
            }
            if(Input.GetKeyDown(KeyCode.Insert)) 
            {
                dev.Autosave(); //Autosaving :D
            }
            if (Input.GetKeyDown(KeyCode.End))
            {
                dev.FreeAllPrisoners();
                string mx = kingdom.ActiveName;
                Directory.CreateDirectory(@"C:\KoH2Cheat");
                File.WriteAllText(@"C:\KoH2Cheat\KingdomName.txt", mx);
            }
            
        }
    }
}
