using System.Collections;

namespace SDA_46337z_07
{
    internal class BulStat : DictionaryBase
    {
        public BulStat()
        {

        }
        public void Add(string companyName, string bs)
        {
            base.InnerHashtable.Add(companyName, bs);
        }
        public string Item(string companyName)
        {
            return base.InnerHashtable[companyName].ToString();
        }
        public void Remove(string companyName)
        {
            base.InnerHashtable.Remove(companyName);
        }

        public bool Contains(string companyName)
        {
            return base.InnerHashtable.Contains(companyName);
        }
        public string ShowDictionary()
        {
            string s;

            if (base.InnerHashtable.Count == 0)
            {
                s = "Речникът е празен\n";
            } else
            {
                s = "Речник: \n";
                foreach(object element in base.InnerHashtable.Keys)
                {
                    string key = element.ToString();
                    s += key + " - " + base.InnerHashtable[key].ToString() + "\n";
                }
            }
            return s;
        }
    }
}