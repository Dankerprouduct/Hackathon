using UnityEngine;
using System.Collections;

public class ArmorPieces : MonoBehaviour {


    public string pieceName;
    public int itemID;
    public ArmorType armor;
    public float speed;
    public float health; 

    public enum ArmorType
    {
        Helmet, 
        Torso, 
        RightForearm,
        LeftForearm,
        RightBicep,
        LeftBicep,
        RightFoot,
        LeftFoot
    }

    public ArmorPieces(string name, int id, ArmorType type, float itemSpeed, float itemHealth)
    {
        pieceName = name;
        itemID = id;
        armor = type;
        speed = itemSpeed;
        health = itemHealth;
    }

    public ArmorPieces()
    {

    }
}
