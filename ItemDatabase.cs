using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {


    public List<ArmorPieces> armor = new List<ArmorPieces>(); 
    void Awake()
    {
        // basic set one
        armor.Add(new ArmorPieces("Head", 0, ArmorPieces.ArmorType.Helmet, "Basic Helmet", 0, 0));
        armor.Add(new ArmorPieces("Torso", 1, ArmorPieces.ArmorType.Torso, "Basic Torso", 0f, 0f));
        armor.Add(new ArmorPieces("Right Bicep", 2, ArmorPieces.ArmorType.RightBicep, "Basic Bicep", 0, 0));
        armor.Add(new ArmorPieces("Left Bicep", 3, ArmorPieces.ArmorType.LeftForearm, "Basic Bicep", 0, 0));
        armor.Add(new ArmorPieces("Right Forearm", 4, ArmorPieces.ArmorType.RightForearm, "Basic Forearm", 0, 0));
        armor.Add(new ArmorPieces("Left Forearm", 5, ArmorPieces.ArmorType.LeftForearm, "Basic Forearm", 0, 0));
        armor.Add(new ArmorPieces("Right Calf", 6, ArmorPieces.ArmorType.RightCalf, "Basic Calf", 0, 0));
        armor.Add(new ArmorPieces("Left Calf", 7, ArmorPieces.ArmorType.LeftCalf, "Basic Calf", 0, 0));
        armor.Add(new ArmorPieces("Right Thigh", 8, ArmorPieces.ArmorType.RightThigh, "Basic Thigh", 0, 0));
        armor.Add(new ArmorPieces("Left Thigh", 9, ArmorPieces.ArmorType.LeftThigh, "Basic Thigh", 0, 0));
        armor.Add(new ArmorPieces("Skirt", 10, ArmorPieces.ArmorType.SkirtPiece, "Basic Thigh", 0, 0));
        
        // Vindicator


    }

}
