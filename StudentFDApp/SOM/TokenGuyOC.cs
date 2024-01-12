// **************************************************************************************************
//		CTokenGuyOC
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
  public class CTokenGuyOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute TokensToGive;
    public HlaAttribute TID;
    #endregion //Declarations
    
    #region Constructor
    public CTokenGuyOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.TokenGuy";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // TokensToGive
      TokensToGive = new HlaAttribute("TokensToGive", PSKind.PublishSubscribe);
      Attributes.Add(TokensToGive);
      // TID
      TID = new HlaAttribute("TID", PSKind.PublishSubscribe);
      Attributes.Add(TID);
    }
    #endregion //Constructor
  }
}
