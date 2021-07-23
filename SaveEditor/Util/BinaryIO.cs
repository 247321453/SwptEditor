using System;
using System.IO;
using System.Text;

namespace Common
{
    public static  class BinaryIO
    {

        //背包
        //FF D5 0 9A B5 0 0 0 0 0 0 0 0
        //0 0 80 3F 0 0 0 0
        public static bool Compare(this byte[] Data, byte[] TYPE, int start = 0, int len = -1)
        {
            if (len < 0) {
                len = TYPE.Length;
            }
            if (Data == null || Data.Length < len)
            {
                return false;
            }
            for (int i = 0; i < len; i++)
            {
                if (Data[start + i] != TYPE[i])
                {
                    return false;
                }
            }
            return true;

        }
        public static Encoding Default = Encoding.UTF8;//Encoding.ASCII
        public static int ReadCD(this BinaryReader br) {
            return br.ReadByte() & 0xFF;
        }

        public static long ReadDQ(this BinaryReader br)
        {
            return br.ReadUInt32();
        }

        public static string ReadAnsiString(this BinaryReader br, int len=-1)
        {
            if (len < 0) {
                len = br.ReadCD();
            }
            byte[] bs = br.ReadBytes(len);
            if (bs.Length != len) {
                throw new Exception("read bytes error:"+ bs.Length + "<"+len);
            }
            return Default.GetString(bs);
        }

        public static string ReadAnsiString(this byte[] data, int start, int len)
        {
            byte[] bs = new byte[len];
            for (int i = start, j = 0; j < len; i++,j++) {
                bs[j] = data[i];
            }
            return Default.GetString(bs);
        }

        public static void WriteAnsiString(this BinaryWriter output, string str)
        {
            byte[] bs = Default.GetBytes(str);
            output.Write((byte)bs.Length);
            output.Write(bs);
        }

        public static void WriteAnsiString(this ByteArrayOutputSteam output, string str)
        {
            byte[] bs = Default.GetBytes(str);
            output.Write((byte)bs.Length);
            output.Write(bs);
        }

        public static string ReadAnsiString(this ByteArrayInputSteam input)
        {
            int len = input.ReadCD();
            byte[] bs = input.ReadBytes(len);
            return Default.GetString(bs);
        }
    }
}
