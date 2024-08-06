//
// C# (Search Bytes Engine)
// SeekTools
// v 0.2, 25.07.2024
// github.com/dkxce
// en,ru,1251,utf-8
//

using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Seek
{
    internal static class SeekTools
    {
        private static int BUFFER_SIZE = 2 * 1024 * 1024; /* 2 MB */

        #region Safe
        public static int SeekData(byte[] data, int offset, int dataSize, string asciiString)
        {
            return SeekData(data, offset, dataSize, Encoding.ASCII.GetBytes(asciiString));
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, string asciiString)
        {
            return SeekData(data, offset, dataSize, Encoding.ASCII.GetBytes(asciiString));
        }

        public static int SeekData(char[] data, int offset, int dataSize, string asciiString)
        {
            return SeekData(data, offset, dataSize, Encoding.ASCII.GetBytes(asciiString));
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, string asciiString)
        {
            return SeekData(data, offset, dataSize, Encoding.ASCII.GetBytes(asciiString));
        }

        public static int SeekData(char[] data, int offset, int dataSize, byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }
        
        public static int SeekData(ref char[] data, int offset, int dataSize, byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek)
        {
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        #endregion Safe

        #region Unsafe

        public static unsafe int SeekData(byte* data, int offset, int dataSize, byte* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(byte* data, int offset, int dataSize, byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(byte* data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(byte[] data, int offset, int dataSize, byte* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(ref byte[] data, int offset, int dataSize, byte* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(char* data, int offset, int dataSize, char* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(char* data, int offset, int dataSize, char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(char* data, int offset, int dataSize, ref char[] b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(char[] data, int offset, int dataSize, char* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        public static unsafe int SeekData(ref char[] data, int offset, int dataSize, char* b2seek, int b2seekSize)
        {
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            return -1;
        }

        #endregion Unsafe

        #region Streams

        public static int SeekData(Stream stream, long offset, long dataSize, string asciiString)
        {
            return SeekData(stream, offset, dataSize, Encoding.ASCII.GetBytes(asciiString));
        }

        public static int SeekData(Stream stream, long offset, long dataSize, byte[] b2seek)
        {
            long b2seekSize = b2seek.Length;

            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        public static int SeekData(Stream stream, long offset, long dataSize, byte[] b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        public static int SeekData(Stream stream, long offset, long dataSize, ref byte[] b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }        

        public static int SeekData(Stream stream, long offset, long dataSize, char[] b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != (byte)b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        public static int SeekData(Stream stream, long offset, long dataSize, ref char[] b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != (byte)b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        public static unsafe int SeekData(Stream stream, long offset, long dataSize, byte* b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        public static unsafe int SeekData(Stream stream, long offset, long dataSize, char* b2seek, long b2seekSize)
        {
            byte[] buff = new byte[BUFFER_SIZE]; // 2 MB
            stream.Position = offset;
            long readed = 0, matched = 0, dlen;
            while (true)
            {
                if (stream.Position >= dataSize) return -1;
                if ((dlen = stream.Read(buff, 0, buff.Length)) == 0) return -1;
                for (long pos = 0; pos < dlen; pos++)
                    if (buff[pos] != (char)b2seek[matched]) matched = 0;
                    else if (++matched == b2seekSize)
                        return (int)(offset + readed + pos + 1 - b2seekSize);
                readed += dlen;
            };
        }

        #endregion Streams

        #region HEX TOOLS

        public static byte[] HexStringToBytes(string hexString) /* NOT TESTED */
        {
            if (hexString.Length % 2 == 1) throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "Wrong string length: {0}", hexString));
            byte[] arr = new byte[hexString.Length >> 1];
            for (int i = 0; i < hexString.Length >> 1; ++i)
                arr[i] = (byte)((GetHexVal(hexString[i << 1]) << 4) + (GetHexVal(hexString[(i << 1) + 1])));
            return arr;
        }

        public static int GetHexVal(byte hex, byte mode = 0 /* 0 - both case, 1 - lower, 2 - upper */)
        {
            return GetHexVal((char)hex, mode);
        }

        public static int GetHexVal(char hex, byte mode = 0 /* 0 - both case, 1 - lower, 2 - upper */)
        {
            byte val = (byte)hex;
            if (mode == 1)
                return val - (val < 58 ? 48 : 87);
            else if (mode == 2)
                return val - (val < 58 ? 48 : 55);
            else
                return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        #endregion HEX TOOLS

        #region Counter Start/End Tools

        public static int SeekData(char[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize, ref uint bytesEmptyStart, ref uint bytesEmptyEnd)
        {
            bytesEmptyStart = 0;
            bytesEmptyEnd = 0;
            int matched = 0;
            bool calcStart = true;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) { bytesEmptyEnd++; if (calcStart) bytesEmptyStart++; } else { bytesEmptyEnd = 0; calcStart = false; };
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        #endregion Counter Start/End Tools

        #region Counter End Tools

        public static int SeekData(char[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if ((byte)data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, byte[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, char[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            };
            return -1;
        }

        public static int SeekData(ref byte[] data, int offset, int dataSize, ref byte[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int b2seekSize = b2seek.Length;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        public static int SeekData(ref char[] data, int offset, int dataSize, ref char[] b2seek, int b2seekSize, ref uint bytesEmptyEnd)
        {
            bytesEmptyEnd = 0;
            int matched = 0;
            for (int pos = offset; pos < dataSize; pos++)
            {
                if (data[pos] == 0) bytesEmptyEnd++; else bytesEmptyEnd = 0;
                if (data[pos] != b2seek[matched]) matched = 0;
                else if (++matched == b2seekSize)
                    return pos + 1 - b2seekSize;
            }
            return -1;
        }

        #endregion Counter End Tools
    }
}
