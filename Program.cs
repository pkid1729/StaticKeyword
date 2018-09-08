using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
           pkclass pk=new pkclass();
           pk.sayMyName("Pranav");
           pkstaticclass.sayMyName("Prem");
        }
    }
}
