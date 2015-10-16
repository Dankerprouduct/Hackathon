using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {


    public List<ArmorPieces> armor = new List<ArmorPieces>(); 
    /// <summary>
    ///  naming scheme
    ///  101 
    ///  - first set, first peice
    ///  102
    ///  - first set second peice
    ///  
    ///  404 
    ///  - fourth set, fourth peice
    ///  412
    ///  - fourth set, 12 peice
    /// </summary>
    void Awake()
    {
        
        // basic set one
        armor.Add(new ArmorPieces("Basic Head", 101, ArmorPieces.ArmorType.Helmet, "Basic Helmet", 0, 0));
        armor.Add(new ArmorPieces("Basic Torso", 102, ArmorPieces.ArmorType.Torso, "Basic Torso", 0f, 0f));
        armor.Add(new ArmorPieces("Basic Right Bicep", 103, ArmorPieces.ArmorType.RightBicep, "Basic Bicep", 0, 0));
        armor.Add(new ArmorPieces("Basic Left Bicep", 104, ArmorPieces.ArmorType.LeftForearm, "Basic Bicep", 0, 0));
        armor.Add(new ArmorPieces("Basic Right Forearm", 105, ArmorPieces.ArmorType.RightForearm, "Basic Forearm", 0, 0));
        armor.Add(new ArmorPieces("Basic Left Forearm", 106, ArmorPieces.ArmorType.LeftForearm, "Basic Forearm", 0, 0));
        armor.Add(new ArmorPieces("Basic Right Calf", 107, ArmorPieces.ArmorType.RightCalf, "Basic Calf", 0, 0));
        armor.Add(new ArmorPieces("Basic Left Calf", 108, ArmorPieces.ArmorType.LeftCalf, "Basic Calf", 0, 0));
        armor.Add(new ArmorPieces("Basic Right Thigh", 109, ArmorPieces.ArmorType.RightThigh, "Basic Thigh", 0, 0));
        armor.Add(new ArmorPieces("Basic Left Thigh", 110, ArmorPieces.ArmorType.LeftThigh, "Basic Thigh", 0, 0));
        armor.Add(new ArmorPieces("Basic Skirt", 111, ArmorPieces.ArmorType.SkirtPiece, "Basic Thigh", 0, 0));
        armor.Add(new ArmorPieces("Basic Right Foot", 112, ArmorPieces.ArmorType.RightFoot, "Basic Foot", 0, 0));
        armor.Add(new ArmorPieces("Basic Left Foot", 113, ArmorPieces.ArmorType.LeftFoot, "Basic Foot", 0, 0)); 
        
        // Vindicator
        armor.Add(new ArmorPieces("Vindicator Head", 201, ArmorPieces.ArmorType.Helmet, "Vindicator Helmet", 0, 0));
        armor.Add(new ArmorPieces("Vindicator Torso", 202, ArmorPieces.ArmorType.Torso, "Vindicator Torso", 0, 0));
        armor.Add(new ArmorPieces("Vindicator Right Bicep", 203, ArmorPieces.ArmorType.RightBicep, "Vindicator Right Bicep", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Left Bicep", 204, ArmorPieces.ArmorType.LeftBicep,"Vindicator Left Bicep", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Right Forearm", 205, ArmorPieces.ArmorType.RightForearm,"Vindicator Right Forearm", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Left Forearm", 206, ArmorPieces.ArmorType.LeftForearm,"Vindicator Left Forearm", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Right Calf", 207, ArmorPieces.ArmorType.RightCalf, "Vindicator Right Calf", 0, 0));
        armor.Add(new ArmorPieces("Vindicator Left Calf", 208, ArmorPieces.ArmorType.LeftCalf, "Vindicator Left Calf", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Right Thigh", 209, ArmorPieces.ArmorType.RightThigh, "Vindicator Right Thigh", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Left Thigh", 210, ArmorPieces.ArmorType.LeftThigh, "Vindicator Left Thigh", 0, 0));
        armor.Add(new ArmorPieces("Vindicator Skirt", 211, ArmorPieces.ArmorType.SkirtPiece, "Vindicator Skirt  Piece", 0, 0));
        armor.Add(new ArmorPieces("Vindicator Right Foot", 212, ArmorPieces.ArmorType.RightFoot, "Vindicator Right Foot", 0, 0)); 
        armor.Add(new ArmorPieces("Vindicator Left Foot", 213, ArmorPieces.ArmorType.LeftFoot, "Vindicator Left Foot", 0, 0)); 


    }

}
