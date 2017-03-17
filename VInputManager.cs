using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Console;

namespace VirtualInput
{
    /// <summary>
    /// In progress (will most likely be removed).
    /// I plan on using this to detect if a binded key to a console 
    /// command was pressed.
    /// 
    /// Deprecated
    /// </summary>
    public class VInputManager : MonoBehaviour
    {

        void Awake()
        {
            ConsoleCommandDatabase.RegisterCommand("bind",
                "Binds a key to a virtual key.",
                "[key] [action]",
                Cmd_bind);
            ConsoleCommandDatabase.RegisterCommand("unbind", "unbinds the key", "[key]", Cmd_unbind);
            ConsoleCommandDatabase.RegisterCommand("bindlist", "list test", "", cmd_list);
        }

        void Update()
        {
           // foreach(BindedKey bind in binds)
            //    bind.keyPressCallBack();
        }

        #region Console Commands

        void keybind()
        {
            Debug.Log("IT WORKS!!!");
            VInputHelper.KeyToString(KeyCode.Joystick8Button7);
        }

        string cmd_list(string[] args)
        {
            string message = "";
            for (int i = 0; i < 100; ++i)
            {
                message += ((KeyCode)i).ToString() + "\n";
            }
            return message + "Finnished!";
        }

        private string Cmd_bind(string[] args)
        {
            VInput.BindKey(VInputHelper.StringToKey(args[0]), args[1]);
            return "";
        }

        private string Cmd_unbind(string[] args)
        {
            VInput.UnbindKey(VInputHelper.StringToKey(args[1]), args[0]);
            return "";
        }
        #endregion
    }
}