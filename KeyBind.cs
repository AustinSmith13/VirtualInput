using UnityEngine;

namespace VirtualInput
{
    /// <summary>
    /// Used for translating string's to KeyCode's or
    /// vice versa. Mainly for helping Console to translate arguments.
    /// </summary>
    public static class VInputHelper
    {
        // KeyMapping
        private static KeyCode[] keys = new KeyCode[75] {
            KeyCode.W,
            KeyCode.A,
            KeyCode.S,
            KeyCode.D,
            KeyCode.E,
            KeyCode.R,
            KeyCode.Space,
            KeyCode.LeftShift,
            KeyCode.LeftAlt,
            KeyCode.B,
            KeyCode.C,
            KeyCode.F,
            KeyCode.G,
            KeyCode.H,
            KeyCode.I,
            KeyCode.J,
            KeyCode.K,
            KeyCode.L,
            KeyCode.M,
            KeyCode.N,
            KeyCode.O,
            KeyCode.P,
            KeyCode.Q,
            KeyCode.T,
            KeyCode.U,
            KeyCode.V,
            KeyCode.W,
            KeyCode.X,
            KeyCode.Y,
            KeyCode.Z,
            KeyCode.Mouse0,
            KeyCode.Mouse1,
            KeyCode.Mouse2,
            KeyCode.Mouse3,
            KeyCode.Mouse4,
            KeyCode.Mouse5,
            KeyCode.Mouse6,
            KeyCode.Tab,
            KeyCode.F1,
            KeyCode.F2,
            KeyCode.F3,
            KeyCode.F4,
            KeyCode.F5,
            KeyCode.F6,
            KeyCode.F7,
            KeyCode.F8,
            KeyCode.F9,
            KeyCode.F10,
            KeyCode.F11,
            KeyCode.F12,
            KeyCode.F13,
            KeyCode.F14,
            KeyCode.F15,
            KeyCode.Escape,
            KeyCode.Delete,
            KeyCode.Backspace,
            KeyCode.Keypad0,
            KeyCode.Keypad1,
            KeyCode.Keypad2,
            KeyCode.Keypad3,
            KeyCode.Keypad4,
            KeyCode.Keypad5,
            KeyCode.Keypad6,
            KeyCode.Keypad7,
            KeyCode.Keypad8,
            KeyCode.Keypad9,
            KeyCode.KeypadDivide,
            KeyCode.KeypadEnter,
            KeyCode.KeypadEquals,
            KeyCode.KeypadMinus,
            KeyCode.KeypadMultiply,
            KeyCode.KeypadPeriod,
            KeyCode.KeypadPlus,
            KeyCode.LeftControl,
            KeyCode.RightControl
        };

        private static string[] keyNames = new string[75] {
            "w", "a", "s", "d", "e", "r", "space", "leftshift",
            "leftalt", "b", "c", "f", "g", "h", "i", "j", "k","l",
            "m", "n", "o", "p", "q", "t", "u", "v", "w", "x", "y",
            "z", "mouse0", "mouse1", "mouse2", "mouse3", "mouse4",
            "mouse5", "mouse6", "tab", "f1", "f2", "f3", "f4", "f5",
            "f6", "f7", "f8", "f9", "f10", "f11", "f12", "f13", "f14",
            "f15", "escape", "delete", "backspace", "keypad0", "keypad1",
            "keypad2", "keypad3", "keypad4", "keypad5", "keypad6", 
            "keypad7", "keypad8", "keypad9", "keypad_divide",
            "keypad_enter", "keypad_equals", "keypad_minus", 
            "keypad_multiply", "keypad_period", "keypad_plus", "leftcontrol", "rightcontrol"
        };

       /* public static BindType StringToBindType(string type)
        {
            for (int i = 0; i < bindTypes.Length; ++i)
                if (type == bindTypes[i])
                    return (BindType)i;

            return BindType.None;
        }*/

        public static KeyCode StringToKey(string key)
        {
            for (int i = 0; i < keyNames.Length; ++i)
                if (key == keyNames[i])
                    return keys[i];

            return KeyCode.None;
        }

        public static string KeyToString(KeyCode key)
        {
            for(int i = 0; i < keys.Length; ++i)
            {
                if (key == keys[i])
                    return keyNames[i];
            }
            throw new NoSuchKeyException();
        }

        
    }
}