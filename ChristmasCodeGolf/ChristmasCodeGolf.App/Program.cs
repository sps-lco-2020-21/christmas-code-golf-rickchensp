﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace A
{
    class A
    {
        static void Main()
        {
            List<string>n=new List<string>{"first","second","third","fourth","fifth","sixth","seventh","eighth","ninth","tenth","eleventh","twelfth"};
            List<string>i=new List<string> {"\nTwo turtle doves,\n","\nThree French hens","\nFour calling birds","\nFive golden rings","\nSix geese a-laying","\nSeven swans a-swimming","\nEight maids a-milking","\nNine ladies dancing","\nTen lords a-leaping","\nEleven pipers piping","\nTwelve drummers drumming"};
            for(int j=0;j<12;++j)        
                Console.Write("On the {0} day of Christmas,\nmy true love sent to me" +
                    string.Join(",", i.Take(j).Reverse()) + "{1} partridge in a pear tree.\n\n", n[j], j == 0 ? "\nA" : "And a");   
            Console.ReadKey();
        }
    }
}
