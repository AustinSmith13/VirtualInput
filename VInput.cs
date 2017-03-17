using UnityEngine;

namespace VirtualInput
{

    /// <summary>
    /// Virtual input layer that can assign and unassign keys to virtual keys.
    /// </summary>
    public static class VInput
    {
        static IVkeyRepository _repository = new Repository.VKeyRepository();
        static KeyUp _keyupWorker = new KeyUp();
        static KeyDown _keydownWorker = new KeyDown();
        static KeyPress _keypressWorker = new KeyPress();
        static bool disabled = false;

        /// <summary>
        /// Total count of Vkeys registered in the system.
        /// </summary>
        /// <returns></returns>
        public static int VkeyCount()
        {
            return _repository.Count();
        }

        /// <summary>
        /// Enables/Disables Vinput handeling.
        /// </summary>
        /// <param name="state"></param>
        public static void SetEnabled(bool state)
        {
            disabled = !state;
        }

        public static bool IsEnabled()
        {
            return !disabled;
        }

        /// <summary>
        /// Creates a new virtual key.
        /// </summary>
        /// <param name="vkey"></param>
        public static void CreateVKey(VKey vkey)
        {
            string id = vkey.name;
            _repository.InstertVKey(vkey, id);
        }

        /// <summary>
        /// Binds a unity key to a virtual key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vkey"></param>
        public static void BindKey(KeyCode key, string vkey)
        {
            _repository.GetVKeyByID(vkey).BindKey(key);
        }

        /// <summary>
        /// Unbinds a unity key from a virtual key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vkey"></param>
        public static void UnbindKey(KeyCode key, string vkey)
        {
            _repository.GetVKeyByID(vkey).UnbindKey(key);
        }
        
        /// <summary>
        /// Returns true if the given key is pressed.
        /// </summary>
        /// <param name="vkey"></param>
        /// <returns></returns>
        public static bool GetKey(string vkey)
        {
            if (disabled)
                return false;

            return _repository.GetVKeyByID(vkey).CheckKeyPress(_keypressWorker);
        }

        /// <summary>
        /// Returns true if the given key is pressed down during the frame.
        /// </summary>
        /// <param name="vkey"></param>
        /// <returns></returns>
        public static bool GetKeyDown(string vkey)
        {
            if (disabled)
                return false;

            return _repository.GetVKeyByID(vkey).CheckKeyPress(_keydownWorker);
        }
        /// <summary>
        /// Returns true if the given key is released during the frame.
        /// </summary>
        /// <param name="vkey"></param>
        /// <returns></returns>
        public static bool GetKeyUp(string vkey)
        {
            if (disabled)
                return false;

            return _repository.GetVKeyByID(vkey).CheckKeyPress(_keyupWorker);
        }

        /// <summary>
        /// Returns true if the given key passes the given test.
        /// </summary>
        /// <param name="vkey"></param>
        /// <param name="logic"></param>
        /// <returns></returns>
        public static bool GetKey(string vkey, Ivkeypress test)
        {
            if (disabled)
                return false;

            return _repository.GetVKeyByID(vkey).CheckKeyPress(test);
        }
    }
}