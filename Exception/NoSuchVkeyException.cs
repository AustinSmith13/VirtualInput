using System;
using System.Runtime.Serialization;

namespace VirtualInput
{

    [Serializable]
    public class NoSuchVkeyException : Exception
    {

        public string vkey { get; private set; }

        public NoSuchVkeyException() : base() { }

        public NoSuchVkeyException(string message, string vkey)
            : base(message)
        {
            this.vkey = vkey;
        }

        protected NoSuchVkeyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            if (info != null)
                this.vkey = info.GetString("vkey");
        }

        // Perform serialization
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
                info.AddValue("vkey", vkey);
        }
    }
}

