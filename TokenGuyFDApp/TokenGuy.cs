using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using TokenGuyFDApp.SOM;
using TokenGuyFD;

namespace TokenGuyFD
{
    public class CTokenGuy : Racon.CGenericFederate
    {
        public string TID;
        public int TokensToGive;

        public CTokenGuy()
        {
            TID = "1";
            Random rnd = new Random();
            TokensToGive = rnd.Next(1, 21); //tokens given generated randomly for ease, a token guy can at max. give 20 tokens

        }

        public void tokensGiven(int tokensNeeded)
        {
            if (tokensNeeded <= TokensToGive)
            {
                TokensToGive = TokensToGive - tokensNeeded;
                Console.WriteLine(tokensNeeded+ "tokens are given");

          
            }
            else
            {
                Console.WriteLine(tokensNeeded + "Can not be given now");


                Random rnd = new Random();
                TokensToGive = rnd.Next(1, 21); // generating new amount
                                                // Send interaction

                Console.WriteLine("Try again later");


            }
        }
    }
}
