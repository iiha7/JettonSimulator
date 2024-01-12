// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using StudentFD.SOM;
using System.ComponentModel;
using StudentFD;


namespace StudentFD
{
  public class CSimulationManager
  {
    #region Declarations
    // Communication layer related structures
    public CStudentFDApp federate; //Application-specific federate 
                                
    public BindingList<CStudentHlaObject> StudentObjects;
    public BindingList<CTokenGuyHlaObject> TokenGuyObjects;
        
        #endregion //Declarations

        #region Constructor
        public CSimulationManager()
    {
      // Initialize the application-specific federate
      federate = new CStudentFDApp(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "JettonSimulatorFederationExecution";
      federate.FederationExecution.FederateType = "StudentFederate";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
      // Handle RTI type variation
      initialize();

      StudentObjects = new BindingList<CStudentHlaObject>();
      TokenGuyObjects = new BindingList<CTokenGuyHlaObject>();
    }
    #endregion //Constructor
    
    #region Methods
    // Handles naming variation according to HLA specification
    private void initialize()
    {
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO: case RTILibraryType.HLA13_Portico: case RTILibraryType.HLA13_OpenRti:
                federate.Som.StudentOC.Name = "objectRoot.Student";
                federate.Som.StudentOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.TokenGuyOC.Name = "objectRoot.TokenGuy";
                federate.Som.TokenGuyOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.TokenInteractionIC.Name = "interactionRoot.TokenInteraction";
                federate.FederationExecution.FDD = @"D:\\uni\\fall 2023-2024\\Courses Taken\\CNG 1531 Distrbuted Interactive Simulation\\JettonSimulator\\SourceCode\\JettonSimulator\\StudentFDApp\JettonSimulatorFOM.fed";
                    
        break;
        case RTILibraryType.HLA1516e_Portico: case RTILibraryType.HLA1516e_OpenRti:
                federate.Som.StudentOC.Name = "HLAobjectRoot.Student";
                federate.Som.StudentOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.TokenGuyOC.Name = "HLAobjectRoot.TokenGuy";
                federate.Som.TokenGuyOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.TokenInteractionIC.Name = "HLAinteractionRoot.TokenInteraction";
                federate.FederationExecution.FDD = @"D:\\uni\\fall 2023-2024\\Courses Taken\\CNG 1531 Distrbuted Interactive Simulation\\JettonSimulator\\SourceCode\\JettonSimulator\\StudentFDApp\JettonSimulatorFOM.xml";
        break;
      }
    }
    #endregion //Methods
  }
}
