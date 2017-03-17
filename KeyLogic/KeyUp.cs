using UnityEngine;
using System.Collections.Generic;

namespace VirtualInput
{
    public class KeyUp : Ivkeypress
    {
        public bool KeysPressed(List<KeyCode> keys)
        {
            foreach (KeyCode key in keys)
            {
                if (Input.GetKeyUp(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
