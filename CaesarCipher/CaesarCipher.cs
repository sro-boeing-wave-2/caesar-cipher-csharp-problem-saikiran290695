using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder result = new StringBuilder();
            foreach (char character in text)
            {
                if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                {
                    int modindex = (character <= 90) ? character - 65 : character - 97;
                    int retriveIndex = (character <= 90) ? 65 : 97;
                    result.Append((char) ((modindex + shiftKey) % 26 + retriveIndex));
                }
                else
                    result.Append(character);
            }
            return result.ToString();
        }
    }
}
