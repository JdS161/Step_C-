using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    class Foo1
    {
        private int bar;

        public Foo1()
        {
            bar = 0;
        }

        public Foo1 (int bar)
        {
            this.bar = bar;
        }


        public int Bar { get; set; }

        //public int Bar
        //{
        //    get
        //    {
        //        return bar;
        //    }
        //    set
        //    {
        //        this.bar = value;
        //    }
        //}



        private static int staticBar = 10;


        public static void StaticBarSpam()
        {
            for (int i = 0; i < staticBar; i++)
            {
                Console.WriteLine("BAR!");
            }
        }


        public static int StaticBar
        {
            set
            {
                staticBar = value;
            }
        }


        //static constructor
        static Foo1()
        {
            staticBar = 0;
        }
    }
}
