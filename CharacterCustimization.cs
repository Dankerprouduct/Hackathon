using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class CharacterCustimization : MonoBehaviour {

    ItemDatabase database;
    ArmorPieces armorPiece;
	// Use this for initialization
	void Start () 
    {
        database = new ItemDatabase();
        armorPiece = new ArmorPieces(); 

	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        Helmet();
        Torso();
        RightBicep();
        LeftBicep();
        RightForearm();
        LeftForearm();
        Skirt();
        RightThigh();
        LeftThigh();
        RightCalf();
        LeftCalf();
        RightFoot();
        LeftFoot(); 

    }

    List<string> helmet = new List<string>();
    void Helmet()
    {

        for (int i = 0; i < database.armor.Count; i++)
        {
           // if(database.armor[i])
            
        }
    }
    
    List<string> torso = new List<string>();
    void Torso()
    {

    }

    List<string> rightBicep = new List<string>();
    void RightBicep()
    {

    }

    List<string> leftBicep = new List<string>(); 
    void LeftBicep()
    {
        
    }

    List<string> rightForearm = new List<string>();
    void RightForearm()
    {

    }

    List<string> leftForearm = new List<string>();
    void LeftForearm()
    {

    }

    List<string> skirt = new List<string>();
    void Skirt()
    {

    }

    List<string> rightThigh = new List<string>(); 
    void RightThigh()
    {

    }

    List<string> leftthigh = new List<string>(); 
    void LeftThigh()
    {

    }

    List<string> rightCalf = new List<string>(); 
    void RightCalf()
    {

    }

    List<string> leftCald = new List<string>();
    void LeftCalf()
    {

    }

    List<string> rightFoot = new List<string>(); 
    void RightFoot()
    {

    }

    List<string> leftFoor = new List<string>(); 
    void LeftFoot()
    {

    }

}
