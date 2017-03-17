using System.Collections;
using System.Collections.Generic;

namespace VirtualInput.Repository
{
    public class VKeyRepository : IVkeyRepository
    {
        private Hashtable _vkeyRepo = new Hashtable();

        public ICollection GetVKeys()
        {
            return _vkeyRepo.Values;
        }

        public VKey GetVKeyByID(string id)
        {
            return (VKey) _vkeyRepo[id];
        }

        public int Count()
        {
            return _vkeyRepo.Count;
        }

        public void InstertVKey(VKey vkey, string id)
        {
            if (_vkeyRepo.ContainsKey(id))
                throw new System.Exception("The key " + id + " already exists.");

            vkey.id = _vkeyRepo.Count;
            _vkeyRepo.Add(id, vkey);
        }

        public void DeleteVKey(string id)
        {
            _vkeyRepo.Remove(id);
        }

        public void UpdateVKey(VKey vkey, string id)
        {
            if(!_vkeyRepo.ContainsKey(id))
            {
                throw new NoSuchKeyException();
            }

           vkey.name = id;
            _vkeyRepo[id] = vkey;
        }

        public void Save()
        {

        }
    }
}
        