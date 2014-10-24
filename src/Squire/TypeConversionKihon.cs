namespace Squire
{
    using System;

    using Squire.Framework;

    public class TypeConversionKihon : TypeConversionKihonBase
    {
        protected override int Convert_String_To_Int(string data)
        {
            return Convert.ToInt32(data);
        }
    }
}