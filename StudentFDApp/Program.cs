using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racon;
using Racon.RtiLayer;

using System.Threading;
using StudentFD.SOM;
using StudentFD;


namespace StudentFD
{ 


    class Program
        {

            public static int tokensNeeded;
            public static Random rnd;
            public static bool disconnected = false;
            public static int noOfStudents = 0;

            static CSimulationManager manager = new CSimulationManager();


            static void Main(string[] args) {

                PrintVersion();

                manager.federate.StatusMessageChanged += Federate_StatusMessageChanged;
                manager.federate.LogLevel = LogLevel.ALL;

                CStudentHlaObject encapsulatedStudentObject = new CStudentHlaObject(manager.federate.Som.StudentOC);
                encapsulatedStudentObject.student = new CStudent();

                manager.StudentObjects.Add(encapsulatedStudentObject);

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
                tokensNeeded = rnd.Next(1, 6);

                if (tokensNeeded!=0)
                {

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    
                    Console.WriteLine("I need some tokens!: "+ tokensNeeded);
                    Console.WriteLine(manager.federate.SendMessage(0,"I need tokens!", tokensNeeded)); // 0 means take tokens
                    Thread.Sleep(400);
                    Console.ResetColor();


                }

                if (tokensNeeded == 0 || disconnected)
                    break;
            }

            manager.federate.DeleteObjectInstance(manager.StudentObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        private static void PrintVersion()
            {
                Console.WriteLine(
                  "***************************************************************************\n"
                  + "                    " + "Welcome to the StudentFD Application v1.0.0" + "\n"
                  + "***************************************************************************");
            }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CStudentFDApp).StatusMessage);
        }

    }


}

