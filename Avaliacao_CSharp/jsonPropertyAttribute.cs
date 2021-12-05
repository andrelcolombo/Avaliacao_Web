using System;

namespace Avaliacao
{
    internal class jsonPropertyAttribute : Attribute
    {
        public jsonPropertyAttribute(string v)
        {
            V = v;
        }

        public string V { get; }
    }
}