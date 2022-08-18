using System;
using System.IO;
using System.Runtime.InteropServices;

namespace StructuredBinaryReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            StructType aStruct;
            int count = Marshal.SizeOf(typeof(StructType));
            byte[] readBuffer = new byte[count];
            //BinaryReader reader = new BinaryReader(stream);
            //readBuffer = reader.ReadBytes(count);
            readBuffer = new byte[] { 0x01, 0x02, 0x03, 0x04};
            GCHandle handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);
            aStruct = (StructType)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(StructType));
            //aStruct.
            handle.Free();
        }

        [StructLayout(LayoutKind.Explicit)]
        struct StructType
        {
            /*[FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string FileDate;

            [FieldOffset(8)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string FileTime;  */

            [FieldOffset(0)]
            public int Id1;

           /* [FieldOffset(20)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 66)] //Or however long Id2 is.
            public string Id2;  */
        }
    }
}
