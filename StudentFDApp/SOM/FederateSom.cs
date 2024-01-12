// **************************************************************************************************
//		FederateSom
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
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public CStudentOC StudentOC;
    public CTokenGuyOC TokenGuyOC;
    public CTokenInteractionIC TokenInteractionIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      StudentOC = new CStudentOC();
      AddToObjectModel(StudentOC);
      TokenGuyOC = new CTokenGuyOC();
      AddToObjectModel(TokenGuyOC);
      TokenInteractionIC = new CTokenInteractionIC();
      AddToObjectModel(TokenInteractionIC);
    }
    #endregion //Constructor
  }
}
