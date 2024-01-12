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
/// The application specific federate that is extended from the Generic Federate Class of RACoN API
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
    #region Declarations
    public SOM.FederateSom Som;
    #endregion //Declarations
    
    #region Constructor
    public CStudentFDApp() : base(RTILibraryType.HLA1516e_OpenRti)
    {
      // Create and Attach Som to federate
      Som = new SOM.FederateSom();
      SetSom(Som);
    }
    #endregion //Constructor
    
    
  }
}
