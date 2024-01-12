// **************************************************************************************************
//		CTokenInteractionIC
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
/// This class is extended from the object model of RACoN API
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


namespace StudentFD.SOM
{
  public class CTokenInteractionIC : HlaInteractionClass
    {
    #region Declarations
    public HlaParameter giveOrTake;
    public HlaParameter amount;
    public HlaParameter message;

    #endregion //Declarations
    
    #region Constructor
    public CTokenInteractionIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.TokenInteraction";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // giveOrTake
      giveOrTake = new HlaParameter("giveOrTake");
      Parameters.Add(giveOrTake);
      // amount
      amount = new HlaParameter("amount");
      Parameters.Add(amount);
      // message
      message = new HlaParameter("message");
      Parameters.Add(message);
    }
    #endregion //Constructor
  }
}
