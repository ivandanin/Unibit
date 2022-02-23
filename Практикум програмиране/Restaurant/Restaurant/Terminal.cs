using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public interface Terminal
    {
        public void WriteLine(string message);
        public string ReadLine();
        public void WriteLine(string message, params string[] parameters);
        public void Start();
    }
}
