using System;
using System.Text;

namespace DSBooking.Infrastructure.Encryptor
{
    public class BasicEncryptor : IEncryptor
    {
        private const int SHIFT = 4;

        public string Encrypt(string key)
        {
            if (key is null) return string.Empty;

            var sb = new StringBuilder(key.Length);

            foreach (char c in key)
            {
                if (char.IsUpper(c))
                {
                    // A..Z
                    char baseChar = 'A';
                    int mod = 26;
                    char enc = (char)(baseChar + ((c - baseChar + SHIFT) % mod));
                    sb.Append(enc);
                }
                else if (char.IsLower(c))
                {
                    // a..z
                    char baseChar = 'a';
                    int mod = 26;
                    char enc = (char)(baseChar + ((c - baseChar + SHIFT) % mod));
                    sb.Append(enc);
                }
                else if (char.IsDigit(c))
                {
                    // 0..9
                    char baseChar = '0';
                    int mod = 10;
                    char enc = (char)(baseChar + ((c - baseChar + SHIFT) % mod));
                    sb.Append(enc);
                }
                else
                {
                    // ostali karakteri ostaju nepromenjeni
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public string Decrypt(string key)
        {
            if (key is null) return string.Empty;

            var sb = new StringBuilder(key.Length);

            foreach (char c in key)
            {
                if (char.IsUpper(c))
                {
                    char baseChar = 'A';
                    int mod = 26;
                    // dodaj mod pre modulo da izbegnemo negativne vrednosti
                    char dec = (char)(baseChar + ((c - baseChar - SHIFT + mod) % mod));
                    sb.Append(dec);
                }
                else if (char.IsLower(c))
                {
                    char baseChar = 'a';
                    int mod = 26;
                    char dec = (char)(baseChar + ((c - baseChar - SHIFT + mod) % mod));
                    sb.Append(dec);
                }
                else if (char.IsDigit(c))
                {
                    char baseChar = '0';
                    int mod = 10;
                    char dec = (char)(baseChar + ((c - baseChar - SHIFT + mod) % mod));
                    sb.Append(dec);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}