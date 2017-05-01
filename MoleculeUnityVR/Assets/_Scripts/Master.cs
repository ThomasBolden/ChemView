/// @file    Master.cs
/// @author  Thomas Bolden (boldenth@msu.edu)
/// @date    Wed Apr 26 18:35:00 EST 2017
/// @brief   Implimenting game start
///
/// This is the file that begins and controls the game. It should:
///     1. Load FileBrowser() to pick the text file
///     2. Pick the format of the file (cml, pdb, mol, etc.)
///     3. Assign the text file to the proper Load{Type}Data.cs script
///     4. Load the data and generate the structures
///
/// Other possibilities:
///     decide scale
///     set position to be in front of face / vr camera rig

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//---------------------------------------------------------------------------\\
 
public class Master : MonoBehaviour {

    void Start(){
        //
        GetComponent<LoadCmlData>().enabled = false;
        GetComponent<LoadPdbData>().enabled = false;
    }

    void Update(){

        // choose the filetype to be loaded
        if      (Input.GetKeyDown("c")){
            GetComponent<LoadCmlData>().enabled = true;
            GetComponent<LoadPdbData>().enabled = false;
        }
        else if (Input.GetKeyDown("p")){
            GetComponent<LoadCmlData>().enabled = false;
            GetComponent<LoadPdbData>().enabled = true;
        }

        // other code

    }
     
}