using UnityEngine;
using System.Collections;

public class ArmControl : MonoBehaviour {

    float moveSpeed;
    private Quaternion lookRotation;
    Vector3 direction;
    private Transform mousePosition; 
	// Use this for initialization
	void Start () 
    {
        moveSpeed = 5f;
        mousePosition = transform.parent.transform; 
	}
	
	// Update is called once per frame
	void Update () 
    {
        PointAtCenter(); 
	}

    private void PointAtCenter()
    {
        direction = (mousePosition.position - transform.position).normalized;
        lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, moveSpeed * Time.deltaTime); 
    }
}
