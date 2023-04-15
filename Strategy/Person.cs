using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy
{
    public class Person
    {
        public int Id { get; set; }

        Random rand = new Random();
        public Person()
        {
            Thread.Sleep(1);
            Id = rand.Next();
        }
    }
}
