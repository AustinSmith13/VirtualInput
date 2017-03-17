using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace VirtualInput
{
    public interface IVkeyRepository
    {
        ICollection GetVKeys();
        VKey GetVKeyByID(string id);
        int Count();
        void InstertVKey(VKey vkey, string id);
        void DeleteVKey(string id);
        void UpdateVKey(VKey vkey, string id);
        void Save();
    }
}