using UnityEngine;
using System.Collections.Generic;

namespace VirtualInput
{
    public interface Ivkeypress
    {
        bool KeysPressed(List<KeyCode> keys);
    }
}