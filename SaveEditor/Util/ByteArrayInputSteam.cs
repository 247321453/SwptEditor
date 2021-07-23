using System;

namespace Common
{
    public class ByteArrayInputSteam : IDisposable
    {
        private byte[] data;

        public ByteArrayInputSteam(byte[] data)
        {
            this.data = data;
        }
        public int Count { get => data.Length; }

        public int Position = 0;

        public short ReadH()
        {
            int pos = Position;
            Position += 2;
            return BitConverter.ToInt16(data, pos);
        }
        public ushort ReadHD()
        {
            int pos = Position;
            Position += 2;
            return BitConverter.ToUInt16(data, pos);
        }
        public float ReadSingle()
        {
            int pos = Position;
            Position += 4;
            return BitConverter.ToSingle(data, pos);
        }
        public byte ReadByte()
        {
            int pos = Position;
            Position += 1;
            return data[pos];
        }
        public byte ReadC()
        {
            return ReadByte();
        }
        public int ReadCD()
        {
            return ReadByte() & 0xFF;
        }
        public int ReadInt32()
        {
            int pos = Position;
            Position += 4;
            return BitConverter.ToInt32(data, pos);
        }
        public int ReadD()
        {
            return ReadInt32();
        }
        public long ReadDQ()
        {
            int pos = Position;
            Position += 4;
            return BitConverter.ToUInt32(data, pos);
        }
        public long ReadQ()
        {
            int pos = Position;
            Position += 8;
            return BitConverter.ToInt64(data, pos);
        }
        public byte[] ReadBytes(int count)
        {
            if (count < 0)
            {
                count = data.Length - Position;
            }
            byte[] bs = new byte[count];
            for (int i = 0; i < count && Position < data.Length; i++)
            {
                bs[i] = data[Position++];
            }
            return bs;
        }

        public void Dispose()
        {
            data = null;
        }
    }
}
