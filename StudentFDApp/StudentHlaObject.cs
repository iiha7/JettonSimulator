// **************************************************************************************************
//		CStudentHlaObject
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
/// This is a wrapper class for local data structures. This class is extended from the object model of RACoN API
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
  public class CStudentHlaObject : HlaObject
  {
        #region Declarations
        // TODO: Declare your local object structure here
        // Your_LocalData_Type Data;
        public CStudent student;

    #endregion //Declarations
    
    #region Constructor
    public CStudentHlaObject(HlaObjectClass _type) : base(_type)
    {
      // TODO: Instantiate local data here
      // var Data = new Your_LocalData_Type();
      student=new CStudent();
    }
    // Copy constructor - used in callbacks
    public CStudentHlaObject(HlaObject _obj) : base(_obj)
    {
            // TODO: Instantiate local data here
            // var Data = new Your_LocalData_Type();
            student = new CStudent();

        }
        #endregion //Constructor
    }
}
