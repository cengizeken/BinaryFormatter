using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeSchema
{
    public static class HelperClass
    { 
        public static int ReverseBytes(this  int val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }

        public static UInt32 ReverseBytes(this UInt32 val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToUInt32(intAsBytes, 0);
        }

        public static UInt16 ReverseBytes(this UInt16 val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToUInt16(intAsBytes, 0);
        }

        public static Int16 ReverseBytes(this Int16 val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt16(intAsBytes, 0);
        }

        public static Int64 ReverseBytes(this Int64 val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt64(intAsBytes, 0);
        }

        public static UInt64 ReverseBytes(this UInt64 val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToUInt64(intAsBytes, 0);
        }
    }
}
