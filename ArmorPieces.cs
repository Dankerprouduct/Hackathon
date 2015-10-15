using UnityEngine;
using System.Collections;

public class ArmorPieces : MonoBehaviour {


    public string pieceName;
    public int itemID;
    public ArmorType armor;
    public string itemDesc; 
    public float speed;
    public float health;
    public GameObject armorModel; 

    public enum ArmorType
    {
        Helmet, 
        Torso, 
        RightForearm,
        LeftForearm,
        RightBicep,
        LeftBicep,
        RightFoot,
        LeftFoot,
        RightCalf,
        LeftCalf,
        RightThigh,
        LeftThigh,
        SkirtPiece
    }

    public ArmorPieces(string name, int id, ArmorType type, string itemDescription, float itemSpeed, float itemHealth)
    {
        pieceName = name;
        itemID = id;
        armor = type;
        itemDesc = itemDescription; 
        speed = itemSpeed;
        health = itemHealth;
        armorModel = Resources.Load<GameObject>("Modles/" + pieceName); 
    }

    public ArmorPieces()
    {

    }
}
