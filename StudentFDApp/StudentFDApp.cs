// **************************************************************************************************
//		CStudentFDApp
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Sunday, January 7, 2024 6:52:04 PM
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of RACoN API. This file is intended for manual code operations.
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using StudentFD.SOM;
using StudentFD;

namespace StudentFD
{
    public partial class CStudentFDApp : Racon.CGenericFederate
    {
        #region Manually Added Code

        // Local Data
        private CSimulationManager manager;
        private bool initialization = true;
        private int counter = 0;



        #region Constructor
        public CStudentFDApp(CSimulationManager parent) : this()
        {
            manager = parent; // Set simulation manager
                              // Create regions manually
        }
        #endregion //Constructor

        #endregion //Manually Added Code

        public bool SendMessage(int giveOrTake, string txt, int amount)
        {
            HlaInteraction interaction = new HlaInteraction(Som.TokenInteractionIC, "TokenInteraction");

            // Add Values
            interaction.AddParameterValue(Som.TokenInteractionIC.giveOrTake, giveOrTake); // int
            interaction.AddParameterValue(Som.TokenInteractionIC.message, txt); // String
            interaction.AddParameterValue(Som.TokenInteractionIC.amount, amount); // int


            // Send interaction
            return (SendInteraction(interaction, "This amount needed from student"));
        }



        #region Event Handlers
        #region Federate Callback Event Handlers
        #region Federation Management Callbacks
        // FdAmb_ConnectionLost
        public override void FdAmb_ConnectionLost(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ConnectionLost(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_ConnectionLost");
            #endregion //User Code
        }
        // FdAmb_FederationExecutionsReported
        public override void FdAmb_FederationExecutionsReported(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationExecutionsReported(sender, data);

            #region User Code
            //throw new NotImplementedException("FdAmb_FederationExecutionsReported");
            #endregion //User Code
        }
        // FdAmb_OnSynchronizationPointRegistrationConfirmedHandler
        public override void FdAmb_OnSynchronizationPointRegistrationConfirmedHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_OnSynchronizationPointRegistrationConfirmedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_OnSynchronizationPointRegistrationConfirmedHandler");
            #endregion //User Code
        }
        // FdAmb_OnSynchronizationPointRegistrationFailedHandler
        public override void FdAmb_OnSynchronizationPointRegistrationFailedHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_OnSynchronizationPointRegistrationFailedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_OnSynchronizationPointRegistrationFailedHandler");
            #endregion //User Code
        }
        // FdAmb_SynchronizationPointAnnounced
        public override void FdAmb_SynchronizationPointAnnounced(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_SynchronizationPointAnnounced(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_SynchronizationPointAnnounced");
            #endregion //User Code
        }
        // FdAmb_FederationSynchronized
        public override void FdAmb_FederationSynchronized(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSynchronized(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSynchronized");
            #endregion //User Code
        }
        // FdAmb_InitiateFederateSaveHandler
        public override void FdAmb_InitiateFederateSaveHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InitiateFederateSaveHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_InitiateFederateSaveHandler");
            #endregion //User Code
        }
        // FdAmb_FederationSaved
        public override void FdAmb_FederationSaved(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSaved(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSaved");
            #endregion //User Code
        }
        // FdAmb_FederationSaveStatusResponse
        public override void FdAmb_FederationSaveStatusResponse(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationSaveStatusResponse(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationSaveStatusResponse");
            #endregion //User Code
        }
        // FdAmb_ConfirmFederationRestorationRequestHandler
        public override void FdAmb_ConfirmFederationRestorationRequestHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ConfirmFederationRestorationRequestHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_ConfirmFederationRestorationRequestHandler");
            #endregion //User Code
        }
        // FdAmb_FederationRestoreBegun
        public override void FdAmb_FederationRestoreBegun(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestoreBegun(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestoreBegun");
            #endregion //User Code
        }
        // FdAmb_InitiateFederateRestoreHandler
        public override void FdAmb_InitiateFederateRestoreHandler(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InitiateFederateRestoreHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_InitiateFederateRestoreHandler");
            #endregion //User Code
        }
        // FdAmb_FederationRestored
        public override void FdAmb_FederationRestored(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestored(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestored");
            #endregion //User Code
        }
        // FdAmb_FederationRestoreStatusResponse
        public override void FdAmb_FederationRestoreStatusResponse(object sender, HlaFederationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_FederationRestoreStatusResponse(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_FederationRestoreStatusResponse");
            #endregion //User Code
        }
        #endregion //Federation Management Callbacks
        #region Declaration Management Callbacks
        // FdAmb_StartRegistrationForObjectClassAdvisedHandler
        public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

            #region User Code
            if (data.ObjectClassHandle == Som.StudentOC.Handle)
            {

                RegisterHlaObject(manager.StudentObjects[0]);
            }
            //throw new NotImplementedException("FdAmb_StartRegistrationForObjectClassAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_StopRegistrationForObjectClassAdvisedHandler
        public override void FdAmb_StopRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_StopRegistrationForObjectClassAdvisedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_StopRegistrationForObjectClassAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_TurnInteractionsOffAdvisedHandler
        public override void FdAmb_TurnInteractionsOffAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TurnInteractionsOffAdvisedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TurnInteractionsOffAdvisedHandler");
            #endregion //User Code
        }
        // FdAmb_TurnInteractionsOnAdvisedHandler
        public override void FdAmb_TurnInteractionsOnAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TurnInteractionsOnAdvisedHandler(sender, data);

            #region User Code
            //throw new NotImplementedException("FdAmb_TurnInteractionsOnAdvisedHandler");
            #endregion //User Code
        }
        #endregion //Declaration Management Callbacks
        #region Object Management Callbacks
        // FdAmb_ObjectDiscoveredHandler
        public override void FdAmb_ObjectDiscoveredHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectDiscoveredHandler(sender, data);

            #region User Code

            if (data.ClassHandle == Som.StudentOC.Handle)
            {
                // Create and add a new player to the list
                CStudentHlaObject newStudent = new CStudentHlaObject(data.ObjectInstance);
                newStudent.Type = Som.StudentOC;
                RequestAttributeValueUpdate(newStudent, string.Empty);
                manager.StudentObjects.Add(newStudent);
                initialization = true;


            }
            throw new NotImplementedException("FdAmb_ObjectDiscoveredHandler");
            #endregion //User Code
        }
        // FdAmb_ObjectRemovedHandler
        public override void FdAmb_ObjectRemovedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectRemovedHandler(sender, data);
            Console.WriteLine("\nFederate has disconnected! \n");
            Program.disconnected = true;
            #region User Code
            //throw new NotImplementedException("FdAmb_ObjectRemovedHandler");
            #endregion //User Code
        }
        // FdAmb_AttributeValueUpdateRequestedHandler
        public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

            #region User Code
            // Call the base class handler
            base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

            #region User Code
            if (data.ObjectInstance.Handle == manager.StudentObjects[0].Handle)
            {
                // Get parameter values
                // 1st method
                // First check wheather the attr is updated or not. Result returns 0/null if the updated attribute set does not contain the attr and its value 
                if (initialization)
                {
                    //manager.federate.UpdateName(manager.StudentObjects[0]);
                    initialization = false;
                }
                else
                {
                    Program.noOfStudents = 0;
                    foreach (CStudentHlaObject student in manager.StudentObjects)
                    {
                        if (student.student.TokensNeeded > 0)
                            Program.noOfStudents++;
                    }
                    counter++;

                    if (Program.noOfStudents > 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(
                          "***************************************************************************\n"
                          + "                             " + "Student  " + counter + "is being served" + "\n"
                          + "***************************************************************************");

                        Console.WriteLine(DateTime.Now.TimeOfDay.Hours + ":" +
                            DateTime.Now.TimeOfDay.Minutes + ":" + DateTime.Now.TimeOfDay.Seconds);
                        manager.StudentObjects[0].student.requestTokens();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Student needs this amount of tokens: " + (manager.StudentObjects[0].student.TokensNeeded).ToString());
                        Console.ResetColor();
                        SendMessage(1, "Student needs this amount of tokens:", manager.StudentObjects[0].student.TokensNeeded);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(
                        "***************************************************************************\n"
                        + "                             " + "No students left!!" + "\n" +
                        "***************************************************************************");



                        SendMessage(1, "No students left!!", 0);
                        Program.disconnected = true;
                    }


                }

            }

        }
        //throw new NotImplementedException("FdA
        //throw new NotImplementedException("FdAmb_AttributeValueUpdateRequestedHandler");
        #endregion //User Code

        // FdAmb_ObjectAttributesReflectedHandler
        public override void FdAmb_ObjectAttributesReflectedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectAttributesReflectedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_ObjectAttributesReflectedHandler");
            #endregion //User Code
        }
        // FdAmb_InteractionReceivedHandler
        public override void FdAmb_InteractionReceivedHandler(object sender, HlaInteractionEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_InteractionReceivedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_InteractionReceivedHandler");
            #endregion //User Code
        }
        #endregion //Object Management Callbacks
        #region Ownership Management Callbacks
        // FdAmb_AttributeOwnershipAssumptionRequested
        public override void FdAmb_AttributeOwnershipAssumptionRequested(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAssumptionRequested(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAssumptionRequested");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed
        public override void FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipUnavailable
        public override void FdAmb_AttributeOwnershipUnavailable(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipUnavailable(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipUnavailable");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipDivestitureNotified
        public override void FdAmb_AttributeOwnershipDivestitureNotified(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipDivestitureNotified(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipDivestitureNotified");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipAcquisitionNotified
        public override void FdAmb_AttributeOwnershipAcquisitionNotified(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipAcquisitionNotified(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionNotified");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipInformed
        public override void FdAmb_AttributeOwnershipInformed(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipInformed(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipInformed");
            #endregion //User Code
        }
        // FdAmb_AttributeOwnershipReleaseRequestedHandler
        public override void FdAmb_AttributeOwnershipReleaseRequestedHandler(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeOwnershipReleaseRequestedHandler(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_AttributeOwnershipReleaseRequestedHandler");
            #endregion //User Code
        }
        // FdAmb_RequestDivestitureConfirmation
        public override void FdAmb_RequestDivestitureConfirmation(object sender, HlaOwnershipManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_RequestDivestitureConfirmation(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_RequestDivestitureConfirmation");
            #endregion //User Code
        }
        #endregion //Ownership Management Callbacks
        #region Time Management Callbacks
        // FdAmb_TimeRegulationEnabled
        public override void FdAmb_TimeRegulationEnabled(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeRegulationEnabled(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeRegulationEnabled");
            #endregion //User Code
        }
        // FdAmb_TimeConstrainedEnabled
        public override void FdAmb_TimeConstrainedEnabled(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeConstrainedEnabled(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeConstrainedEnabled");
            #endregion //User Code
        }
        // FdAmb_TimeAdvanceGrant
        public override void FdAmb_TimeAdvanceGrant(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_TimeAdvanceGrant(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_TimeAdvanceGrant");
            #endregion //User Code
        }
        // FdAmb_RequestRetraction
        public override void FdAmb_RequestRetraction(object sender, HlaTimeManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_RequestRetraction(sender, data);

            #region User Code
            throw new NotImplementedException("FdAmb_RequestRetraction");
            #endregion //User Code
        }
        #endregion //Time Management Callbacks
        #endregion //Federate Callback Event Handlers
      
        #endregion //Event Handlers
        #endregion
    }
}





