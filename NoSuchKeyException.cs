using System;
using System.Runtime.Serialization;

namespace VirtualInput
{

    [Serializable]
    public class NoSuchKeyException : Exception
    {

        public string key { get; private set; }

        public NoSuchKeyException() : base() { }

        public NoSuchKeyException(string message, string key)
            : base(message)
        {
            this.key = key;
        }

        protected NoSuchKeyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            if (info != null)
                this.key = info.GetString("key");
        }

        // Perform serialization
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
                info.AddValue("key", key);
        }
    }
}
