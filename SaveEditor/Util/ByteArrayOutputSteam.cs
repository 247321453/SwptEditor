using System;
using System.Collections.Generic;

namespace Common
{
    public class ByteArrayOutputSteam : IDisposable
    {
        private List<byte> data = new List<byte>();

        public int Count { get => data.Count; }

        public int Position = 0;

        public byte[] ToArray()
        {
            return data.ToArray();
        }
        public void Write(short i)
        {
            Write(BitConverter.GetBytes(i));
        }
        public void Write(float i)
        {
            Write(BitConverter.GetBytes(i));
        }
        public void Write(ushort i)
        {
            Write(BitConverter.GetBytes(i));
        }
        public void Write(byte b)
        {
            bool add = data.Count == Position;
            if (add)
            {
                data.Add(b);
                Position++;
            }
            else
            {
                data.Insert(Position++, b);
            }
        }

        public void Write(int i)
        {
            Write(BitConverter.GetBytes(i));
        }

        public void Write(byte[] bs, int start = 0, int count = -1)
        {
            if (count < 0)
            {
                count = bs.Length;
            }
            bool add = data.Count == Position;
            for (int i = start; i < count; i++)
            {
                if (add)
                {
                    data.Add(bs[i]);
                    Position++;
                }
                else
                {
                    data.Insert(Position++, bs[i]);
                }
            }
        }

        public void Reset()
        {
            data.Clear();
        }

        public void Dispose()
        {
            data.Clear();
        }
    }
}
