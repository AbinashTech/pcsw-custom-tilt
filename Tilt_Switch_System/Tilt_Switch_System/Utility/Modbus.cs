using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tilt_Switch_System.Views;

namespace Tilt_Switch_System.Utility
{

    /// <summary>
    /// ABINASH 
    /// DEVELOP FOR MODBUS ON 28.11.2020
    /// 14 BIT REG TO READ DATA
    /// </summary>
    public static class Modbus
    {
        public static string GetHexString(string data, int bytCount)
        {
            string hexString = string.Empty;
            data = data.TrimEnd('\0');
            if (!string.IsNullOrEmpty(data))
            {
                char[] ch = GetCharArray(data);
                if (ch.Length >= bytCount)
                {
                    byte[] ba = Encoding.Default.GetBytes(ch, 0, bytCount);
                    hexString = BitConverter.ToString(ba);
                    hexString = hexString.Replace("-", "");
                }
                else { hexString = string.Empty; }
            }
            else { hexString = string.Empty; }

            return hexString;
        }

        public static char[] GetCharArray(string data)
        {
            char[] ch = new char[data.Length];
            for (int i = 0; i <= data.Length - 1; i++)
            {
                ch[i] = data[i];
            }
            return ch;
        }

        public static string GetBinaryString(string hexString)
        {
            string resultString = string.Empty;
            string binaryString = string.Empty;
            if (hexString.Length >= 7)
            {
                resultString = string.Concat(hexString.Substring(6, 2), hexString.Substring(8, 2));
                binaryString = Convert.ToString(Convert.ToInt32(resultString, 16));
            }
            return binaryString;
        }

        public static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            int byteLength = hex.Length >> 1;
            byte[] arr = new byte[byteLength];

            for (int i = 0; i < byteLength; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            //return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        // Compute the MODBUS RTU CRC
        public static string GenerateProtocolWithCrc(string protocol)
        {
            UInt16 crc = 0xFFFF;
            byte[] bytes = Modbus.StringToByteArrayFastest(protocol);
            for (int pos = 0; pos < bytes.Length; pos++)
            {
                crc ^= (UInt16)bytes[pos];          // XOR byte into least sig. byte of crc

                for (int i = 8; i != 0; i--)
                {    // Loop over each bit
                    if ((crc & 0x0001) != 0)
                    {      // If the LSB is set
                        crc >>= 1;                    // Shift right and XOR 0xA001
                        crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                        crc >>= 1;                    // Just shift right
                }
            }
            // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
            string _crc = crc.ToString("X4");
            _crc = string.Concat(_crc.Substring(2, 2), _crc.Substring(0, 2));
            return string.Concat(protocol, _crc);
        }
    }
}
