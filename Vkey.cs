using UnityEngine;
using System.Collections.Generic;

namespace VirtualInput
{
    /// <summary>
    /// A container of unity keys. Checks for pressed keys.
    /// </summary>
    public struct VKey
    {
        public int id;
        public string name;

        List<KeyCode> keys;

        public VKey(string name) 
            : this()
        {
            this.name = name;
            this.keys = new List<KeyCode>();
        }

        public void BindKey(KeyCode key)
        {
            if (KeyExists(key))
                return;

            keys.Add(key);
        }

        public void UnbindKey(KeyCode key)
        {
            for(int i = 0; i < keys.Count; ++i)
            {
                if(key == keys[i])
                    keys.RemoveAt(i);
            }
        }

        public bool CheckKeyPress(Ivkeypress logic)
        {
            return logic.KeysPressed(keys);
        }

        private bool KeyExists(KeyCode key)
        {
            foreach(KeyCode k in keys)
            {
                if (k == key)
                    return true;
            }
            return false;
        }

    }
}