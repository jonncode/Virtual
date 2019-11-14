using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BodyParts> listOfParts = new List<BodyParts>();
            listOfParts.Add(new Heart());
            listOfParts.Add(new Appendix());
            foreach (BodyParts p in listOfParts)
            {
                p.CurrentBodyPart();
            }
            Console.ReadKey();
        }
    }
}
