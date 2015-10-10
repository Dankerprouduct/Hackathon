using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

    NetworkView nView;
    NetworkView mView;
    public GameObject weapon1;
    LineRenderer line;
    float range;
    RaycastHit hit;
    public Material lineMaterial;
    int ammo; 
	// Use this for initialization
	void Start () 
    {
        Cursor.visible = false; 
        range = 1000f;
        ammo = 1000; 
        line = GetComponent<LineRenderer>();
        line.SetVertexCount(2);
        line.material = lineMaterial;
        line.SetWidth(1, 1);
        line.SetPosition(0, transform.position); 

        mView = GetComponent<NetworkView>(); 
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (mView.isMine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                FireWeapon();
            }
            else
            {
                line.enabled = false; 
            }
            
        }

	}

    void OnGUI()
    {
        if (mView.isMine)
        {
            GUI.Box(new Rect(10, Screen.height - 80, (ammo / 4), 50), "Ammo"); 
        }
    }

    void GUIAmmo()
    {

    }
    void FireWeapon()
    {
        line.enabled = true; 
        Transform firePoint = transform.FindChild("FP").transform; 
        Ray ray = new Ray(firePoint.position, firePoint.forward);

        if (Physics.Raycast(ray, out hit, range))
        {
            line.enabled = true; 
            line.SetPosition(0, firePoint.position);
            line.SetPosition(1, hit.point + hit.normal);
            if (hit.collider.tag == "Player")
            {
                nView = hit.collider.GetComponent<NetworkView>();
                nView.RPC("RPCTakeDamage", nView.owner, 5f); 
            }
            ammo--; 
        }
        else
        {
            line.enabled = false; 
        }
    }
    
    [RPC]
    void RPCTakeDamage(float damage)
    {

    }
}
