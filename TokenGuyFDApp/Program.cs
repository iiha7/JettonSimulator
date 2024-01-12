using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racon;
using Racon.RtiLayer;

using System.Threading;
using TokenGuyFDApp.SOM;
using TokenGuyFD;


namespace TokenGuyFD
{

    class Program
    {

        public static int tokensToGive;
        public static Random rnd;
        public static bool disconnected = false;
        public static int noOfTokenGuys = 0;

        static CSimulationManager manager = new CSimulationManager();


        static void Main(string[] args)
        {

            PrintVersion();

            manager.federate.StatusMessageChanged += Federate_StatusMessageChanged;
            manager.federate.LogLevel = LogLevel.ALL;

            CTokenGuyHlaObject encapsulatedTokenGuyObject = new CTokenGuyHlaObject(manager.federate.Som.TokenGuyOC);
            encapsulatedTokenGuyObject.TokenGuy = new CTokenGuy();

            manager.TokenGuyObjects.Add(encapsulatedTokenGuyObject);

            if (manager.federate.InitializeFederation(manager.federate.FederationExecution))
            {

                Console.WriteLine("Federation was connected, created, joined, and had federate capabilities declared.\n");
            }




            manager.federate.ListFederationExecutions();

            while (true)
            {
                if (manager.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
                    manager.federate.Run();

                rnd=new Random();

                tokensToGive = rnd.Next(1, 20);

                if (tokensToGive != 0)
                {

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("I have tokens and I can only give this amount!: "+ tokensToGive);
                    Console.WriteLine(manager.federate.SendMessage(1, "I have tokens and I can only give this amount!", tokensToGive)); // 1 means give tokens
                    Thread.Sleep(400);
                    Console.ResetColor();

                }

                if (tokensToGive == 0)
                {
                    Console.WriteLine("Currently no tokens, let me generate more!");
                    Console.WriteLine(manager.federate.SendMessage(1, "Currently no tokens, let me generate more!", tokensToGive)); // 1 means give tokens
                    Thread.Sleep(400);
                    Console.ResetColor();
                }
                    
            }

            manager.federate.DeleteObjectInstance(manager.TokenGuyObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        private static void PrintVersion()
        {
            Console.WriteLine(
              "***************************************************************************\n"
              + "                    " + "Welcome to the TokenGuyFD Application v1.0.0" + "\n"
              + "***************************************************************************");
        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CTokenGuyFDApp).StatusMessage);
        }

    }


}

