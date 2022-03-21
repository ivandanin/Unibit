namespace SDA_46337z_06
{
    internal class Hashing
    {
        public Hashing()
        {

        }
        public int SimpleHash(string s, string[] array)
        {
            int total = 0;
            char[] cname; cname = s.ToCharArray();
            for (int i = 0; i < cname.Length; i++)
            {
                total += (int)cname[i];
            }
            return total % array.Length;
        }
        public string ShowDisturb(string[] array)
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null) 
                {
                    s += i.ToString() + "\t" + array[i] + "\n";
                }
            }
            return s;
        }
    }
}