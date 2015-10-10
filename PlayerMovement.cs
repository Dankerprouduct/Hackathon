using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
    Rigidbody rigidBody;
    NetworkView nView;
    float speed;
    bool showSense = false;

    float health;
    public GUISkin skin;
    bool alive;
    MeshRenderer child;
    Component[] children;
    List<MeshRenderer> childrenMeshRenderer;
    BoxCollider boxCollider; 
    #region Camera Controls

    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 5f;

    public float minimumX = -360F;
    public float maximumX = 360F;

    float rotationX = 0F;
    Quaternion originalRotation;
    #endregion



	void Start () 
    {
        
        alive = true; 
        health = 100f; 
        rigidBody = GetComponent<Rigidbody>();
        nView = GetComponent<NetworkView>();
        speed = 10f;

        if (rigidBody)
        {
            rigidBody.freezeRotation = true;
            originalRotation = transform.localRotation;
        }


	}
	
	// Update is called once per frame
	void Update () 
    {
        if (nView.isMine)
        {
            Movement();
            Cam(); 
        }

	}
    void Movement()
    {


        //Up
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.position += (-1 * transform.right) * speed * Time.deltaTime;
        }
        // Down
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.position += (1 * transform.right) * speed * Time.deltaTime;
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.position += (-1 * transform.forward) * speed * Time.deltaTime;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.position += (transform.forward) * speed * Time.deltaTime; 
        }
        // Jump 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * speed * Time.deltaTime);
        }
    }
    void OnGUI()
    {
        GUI.skin = skin; 
        if (nView.isMine)
        {
            GUI.Box(new Rect(Screen.width - 225, Screen.height - 60, health * 2, 50), "Health", skin.GetStyle("HealthSkin"));
            
        }
    }

    [RPC]
    void RPCTakeDamage(float ammount)
    {
        health = health - ammount;
        CheckStats(); 
    }
    void ClientTakeDamage(float ammount)
    {
        health = health - ammount;
        CheckStats();
    }

    void SetUp()
    {

        boxCollider = GetComponent<BoxCollider>(); 
        children = GetComponentsInChildren<MeshRenderer>();
        childrenMeshRenderer = new List<MeshRenderer>();
        foreach (MeshRenderer mRendeder in children)
        {
            childrenMeshRenderer.Add(mRendeder); 
        }

    }
    void CheckStats()
    {
        if (health > 0)
        {
            alive = true;
            boxCollider.enabled = true;
            for (int i = 0; i < childrenMeshRenderer.Count; i++)
            {
                childrenMeshRenderer[i].enabled = true;
            }
        }
        if (health <= 0)
        {
            alive = false; 
        }

        if (!alive)
        {
            for (int i = 0; i < childrenMeshRenderer.Count; i++)
            {
                childrenMeshRenderer[i].enabled = false; 
            }
            boxCollider.enabled = false;
        }
    }

    #region Camera Movement
    void Cam()
    {
        if (showSense == false)
        {
            if (axes == RotationAxes.MouseXAndY)
            {
                // Read the mouse input axis
                rotationX += Input.GetAxis("Mouse X") * sensitivityX;
                //   rotationY += Input.GetAxis("Mouse Y") * sensitivityY;

                rotationX = ClampAngle(rotationX, minimumX, maximumX);
                //   rotationY = ClampAngle(rotationY, minimumY, maximumY);

                Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
                //  Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);

                transform.localRotation = originalRotation * xQuaternion;
            }
            else if (axes == RotationAxes.MouseX)
            {
                rotationX += Input.GetAxis("Mouse X") * sensitivityX;
                rotationX = ClampAngle(rotationX, minimumX, maximumX);

                Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
                transform.localRotation = originalRotation * xQuaternion;
            }
        }
        //
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
    #endregion
    
}
