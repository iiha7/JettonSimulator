using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racon;
using TokenGuyFDApp.SOM;
using TokenGuyFD;


namespace TokenGuyFD
{
    public class CStudent
    {
        public string SID;
        public int TokensNeeded;
        public static int counter;

        public CStudent()
        {
            counter++;
            SID = SID + (counter.ToString());
            TokensNeeded = 0;

        }

        public void requestTokens()
        {
            Random rnd = new Random();
            TokensNeeded = rnd.Next(1, 6); //tokens needed generated randomly for ease, a student can at max. order 5 tokens
        }
    }
}
