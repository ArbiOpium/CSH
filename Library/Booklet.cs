using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKnP231.Library
{
    public class Booklet : Literature
    {
        public String Author { get; set; } = null!;
        public string Subject { get; set; } = null!;

        public override string GetCard()
        {
            return $"{Author}, {base.Title} - {Subject}";
        }
        public void Print()
        {
            Console.WriteLine("Booklet Print()" + GetCard());       
        }
    }
}
