using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{


    #region Camera Controls
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    //   public float sensitivityX = 15F;
    public float sensitivityY = 5F;

    //  public float minimumX = -360F;
    //   public float maximumX = 360F;

    public float minimumY = -60F;
    public float maximumY = 60F;

    //   float rotationX = 0F;
    float rotationY = 0F;
    Quaternion originalRotation;
    #endregion


    NetworkView nview;
    bool showSens; 
	// Use this for initialization
	void Start () 
    {
        nview = GetComponent<NetworkView>();
        originalRotation = transform.localRotation; 
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (nview.isMine)
        {
            Cam(); 
        }
        else
        {
            Cam(); 
        }
	    
	}

    void Cam()
    {
        if (showSens == false)
        {
            if (axes == RotationAxes.MouseXAndY)
            {
                // Read the mouse input axis
                //  rotationX += Input.GetAxis("Mouse X") * sensitivityX;
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;

                //    rotationX = ClampAngle(rotationX, minimumX, maximumX);
                rotationY = ClampAngle(rotationY, minimumY, maximumY);

                //   Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
                Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);

                transform.localRotation = originalRotation * yQuaternion;
            }
            else
            {
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = ClampAngle(rotationY, minimumY, maximumY);

                Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);
                transform.localRotation = originalRotation * yQuaternion;
            }
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
