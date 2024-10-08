namespace OUCR.Strings
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            string original = input;
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveString(string input)
        {
            string original = input;
            string sinEspacios = original.Replace(" ", "");
            return sinEspacios;
        }
    }
}
