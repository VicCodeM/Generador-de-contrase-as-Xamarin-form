using System;
using System.Collections.Generic;
using System.Text;

namespace GenerarPassword
{
    public class Aleatorio
    {
        public int Inicio(int rn)
        {
            Random gn = new Random();
           rn = gn.Next(12, 30);
            return rn;  
        }
        public string Inn(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890123456789!°#$%&'()*+,-./:@;<=>?@[]^_`{|}~ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψω";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public string Abecedario(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public string Numeros(int longitud)
        {
            const string chars = "1234567890";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string Caracteres(int longitud)
        {
            const string chars = "!°#$%&'()*+,-./:;<=>?@[]^_`{|}~ñ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string Ascii(int longitud)
        {
            const string chars = "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”„†‡•…‰€™!°#$%&'()*+,-./:@;<=>?[]^_`{|}~";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public string LetrasNumeros(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890987654321ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890987654321";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string LetrasCaracter(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!°@#$%&'()*+,-./:;<=>?[]^_`{|}~ñABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!°@#$%&'()*+,-./:;<=>?[]^_`{|}~ñ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string NumerosCaracter(int longitud)
        {
            const string chars = "01234567890123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~ñ01234567890123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~ñ01234567890123456789!°#$%&'()*+,-./:;<=>?@[]^_`{|}~ñ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string LetrasAscii(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”„†‡•…‰€™!°#$%&'()*+,-./:@;<=>?[]^_`{|}~";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string NumerosAscii(int longitud)
        {
            const string chars = "01234567890987654321!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”„†‡•…‰€™!°#$%&'()*+,-./:@;<=>?[]^_`{|}~";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string CaracterAscii(int longitud)
        {
            const string chars = "01234567890987654321!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”„†‡•…‰€™!°#$%&'()*+,-./:@;<=>?[]^_`{|}~";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public string Todos(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890987654321!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”„†‡•…‰€™!°#$%&'()*+,-./:@;<=>?[]^_`{|}~";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public string LetNumCar(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890987654321!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890987654321!°#$%&'()*+,-@./:;<=>?@[]^_`{|}~ñ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public string LetNumAss(int longitud)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890987654321ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz01234567890987654321ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρσςτθφχψωÆæ¾¡¢£¤¥¦§¨©ª«¬®°±²³´¶¹º»¼½¾¿ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿŒœŠšŸƒ–—‘’‚“”";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

    }
}
