using UnityEngine;
using System.Collections.Generic;

namespace VirtualInput
{
    public class KeyDown : Ivkeypress
    {
        public bool KeysPressed(List<KeyCode> keys)
        {
            foreach (KeyCode key in keys)
            {
                if (Input.GetKeyDown(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}