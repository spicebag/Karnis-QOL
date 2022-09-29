//This mod got denied by the modding group cause of "blank code", offered to fix it and it got called pointless.
//Back to VRChat I go!
using ABI_RC.Core.Savior;
using MelonLoader;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using ABI_RC.Core;
using ABI_RC.Core.EventSystem;
using ABI_RC.Core.Player;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarnisQOL
{
    public class QOL : MelonMod
    {
        public bool gameMuted = false;
        public int currentVol = 100;
        public override void OnApplicationStart()
        {
            LoggerInstance.Msg(ConsoleColor.Green, "Melonloader Diagnostics above.");
            LoggerInstance.Msg(ConsoleColor.Green, "If you have any issues regarding Melonloader, please submit your latest.log to Melonloader.");
            LoggerInstance.Msg(ConsoleColor.Blue, "If you have an issue directly with Karnis QOL, please report it to karni#0001");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(ConsoleColor.Blue, "You are going to be alright.");
            LoggerInstance.Msg(ConsoleColor.Blue, "You just stumbled over a stone on the road,");
            LoggerInstance.Msg(ConsoleColor.Blue, "It means nothing.");
            LoggerInstance.Msg(ConsoleColor.Blue, "Your goal lies far beyond this,");
            LoggerInstance.Msg(ConsoleColor.Blue, "Im sure you will overcome this,");
            LoggerInstance.Msg(ConsoleColor.Blue, "You will walk again soon.");
            LoggerInstance.Msg(ConsoleColor.DarkBlue, "- Kentaro Miura");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(ConsoleColor.DarkBlue, "Keybinds :");
            LoggerInstance.Msg(ConsoleColor.Blue, "[P] - Panic Mode (Disables all audio until toggled back on.)");
            LoggerInstance.Msg(ConsoleColor.Blue, "[T] - Force Quit (Forces the game to close down, ");
            LoggerInstance.Msg(ConsoleColor.Blue, "useful if you get crashed or can't close the game.");
            LoggerInstance.Msg(ConsoleColor.Blue, "More features will be added as I learn.");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(" ");
            LoggerInstance.Msg(ConsoleColor.DarkBlue, "Karnis QOL has started successfully.");
            LoggerInstance.Msg(ConsoleColor.DarkBlue, "Karnis QOL and its creator is in no way affiliated with ChilloutVR.");
        }
        //public static Rigidbody rbcvr;
        //public static Transform trcvr;
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (gameMuted == false)
                {
                    LoggerInstance.Msg(ConsoleColor.Red, $"Setting audio to: 0");
                    LoggerInstance.Msg(" ");
                    currentVol = MetaPort.Instance.settings.GetSettingInt("AudioMaster");
                    MetaPort.Instance.settings.SetSettingsInt("AudioMaster", 0);
                    gameMuted = true;
                }

                else if (gameMuted == true)
                {
                    LoggerInstance.Msg(ConsoleColor.Red, $"Setting audio to: {currentVol}");
                    LoggerInstance.Msg(" ");
                    MetaPort.Instance.settings.SetSettingsInt("AudioMaster", currentVol);
                    gameMuted = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                LoggerInstance.Msg(ConsoleColor.Red, "Panic Button Pressed");
                LoggerInstance.Msg(ConsoleColor.Red, "Press [P] to toggle audio again.");
                LoggerInstance.Msg(" ");
            }
            //if (Input.GetKeyDown(KeyCode.R)) *WIP
            {
                //Respawn();
            }
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    LoggerInstance.Msg(ConsoleColor.Red, "Emergency Quit Pressed, exiting in 5 seconds.");
                    Task.Delay(5000).ContinueWith(t => Application.Quit());
                }
            }
        }
    }
}
