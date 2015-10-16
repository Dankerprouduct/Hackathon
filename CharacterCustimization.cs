using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class CharacterCustimization : MonoBehaviour {

    ItemDatabase database;
    ArmorPieces armorPiece;
    List<ArmorPieces> armor = new List<ArmorPieces>();
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
            if (database.armor[i].armor == ArmorPieces.ArmorType.Helmet)
            {
                helmet.Add(database.armor[i].pieceName); 
            }
        }
    }
    
    List<string> torso = new List<string>();
    void Torso()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.Torso)
            {
                torso.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> rightBicep = new List<string>();
    void RightBicep()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.RightBicep)
            {
                rightBicep.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> leftBicep = new List<string>(); 
    void LeftBicep()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.LeftBicep)
            {
                leftBicep.Add(database.armor[i].pieceName);
            }
        }
    }

    List<string> rightForearm = new List<string>();
    void RightForearm()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.RightForearm)
            {
                rightForearm.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> leftForearm = new List<string>();
    void LeftForearm()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.LeftForearm)
            {
                leftForearm.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> skirt = new List<string>();
    void Skirt()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.SkirtPiece)
            {
                skirt.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> rightThigh = new List<string>(); 
    void RightThigh()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.RightThigh)
            {
                rightThigh.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> leftThigh = new List<string>(); 
    void LeftThigh()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.LeftThigh)
            {
                leftThigh.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> rightCalf = new List<string>(); 
    void RightCalf()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.RightCalf)
            {
                rightCalf.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> leftCalf = new List<string>();
    void LeftCalf()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.LeftCalf)
            {
                leftCalf.Add(database.armor[i].pieceName);
            }
        }
    }

    List<string> rightFoot = new List<string>(); 
    void RightFoot()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.RightFoot)
            {
                rightFoot.Add(database.armor[i].pieceName); 
            }
        }
    }

    List<string> leftFoot = new List<string>(); 
    void LeftFoot()
    {
        for (int i = 0; i < database.armor.Count; i++)
        {
            if (database.armor[i].armor == ArmorPieces.ArmorType.LeftFoot)
            {
                leftFoot.Add(database.armor[i].pieceName); 
            }
        }
    }

}
