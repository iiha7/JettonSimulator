// **************************************************************************************************
//		CStudentOC
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
using TokenGuyFDApp.SOM;
using TokenGuyFD;




namespace TokenGuyFDApp.SOM
{
  public class CStudentOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute TokensNeeded;
    public HlaAttribute SID;
    #endregion //Declarations
    
    #region Constructor
    public CStudentOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Student";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // TokensNeeded
      TokensNeeded = new HlaAttribute("TokensNeeded", PSKind.PublishSubscribe);
      Attributes.Add(TokensNeeded);
      // SID
      SID = new HlaAttribute("SID", PSKind.PublishSubscribe);
      Attributes.Add(SID);
    }
    #endregion //Constructor
  }
}
