using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {


    public List<ArmorPieces> armor = new List<ArmorPieces>(); 
    void Awake()
    {
        armor.Add(new ArmorPieces("Head1", 0, ArmorPieces.ArmorType.Helmet, "This head will sadly not give head", 0, 0)); 
        
    }
}
