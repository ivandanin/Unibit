﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Магазин_за_авточасти
{
    public class Shop
    {
        private string name;
        private List<Part> parts;

        public Shop(string name)
        {
            this.name = name;
            this.parts = new List<Part>();
        }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Shop: {this.name}\n\n");
            foreach (Part part in this.parts)
            {
                result.Append(part);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
