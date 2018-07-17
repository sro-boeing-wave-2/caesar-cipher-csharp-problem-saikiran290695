using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string result = "";
            int modindex;
            int retriveIndex;
            foreach (char character in text)
            {
                if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                {
                    modindex = (character <= 90) ? character - 65 : character - 97;
                    retriveIndex = (character <= 90) ? 65 : 97;
                    result += (char)((modindex + shiftKey) % 26 + retriveIndex);
                }
                else
                    result += character;
            }
            return result;
        }
    }
}
