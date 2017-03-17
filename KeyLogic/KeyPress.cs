using UnityEngine;
using System.Collections.Generic;

namespace VirtualInput
{
    public class KeyPress : Ivkeypress
    {
        public bool KeysPressed(List<KeyCode> keys)
        {
            foreach (KeyCode key in keys)
            {
                if (Input.GetKey(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}