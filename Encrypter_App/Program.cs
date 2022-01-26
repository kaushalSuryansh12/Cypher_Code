using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Type your message");
            string msg = Console.ReadLine();
            string msg2;

            char[] secretMessage = msg.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {

                char character = secretMessage[i];

                int j = Array.IndexOf(alphabet, character);

                if (j < 23)
                {
                    char value = alphabet[j + 3];
                    encryptedMessage[i] = value;
                }
                else if (j == 23)
                {
                    char value = alphabet[0];
                    encryptedMessage[i] = value;
                }
                else if (j == 24)
                {
                    char value = alphabet[1];
                    encryptedMessage[i] = value;
                }
                else if (j == 25)
                {
                    char value = alphabet[2];
                    encryptedMessage[i] = value;
                }
                else
                {
                    char value = ' ';
                    encryptedMessage[i] = value;
                }

            }

            msg2 = String.Join("", encryptedMessage);
            Console.WriteLine(msg2);

        }
    }
}
