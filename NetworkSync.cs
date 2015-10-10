using UnityEngine;
using System.Collections;

public class NetworkSync : MonoBehaviour {

    float syncTime;
    float syncDelay;
    float lastSyncTime;

    Vector3 syncStart;
    Vector3 syncEnd;

    Quaternion rotStart;
    Quaternion rotEnd;

    NetworkView nView;
	// Use this for initialization
	void Start () 
    {
        nView = GetComponent<NetworkView>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!nView.isMine)
        {
            SyncedMovement();
        }
	    
	}

    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        Vector3 syncPosition = Vector3.zero;
        Quaternion rot = Quaternion.identity;

        if (stream.isWriting)
        {
            syncPosition = transform.position;
            rot = transform.rotation;

            // serialize

            stream.Serialize(ref syncPosition);
            stream.Serialize(ref rot); 
        }
        else
        {
            // serialize
            stream.Serialize(ref syncPosition); 


            syncTime = 0f;
            syncDelay = Time.time - lastSyncTime;
            lastSyncTime = Time.time;

            syncStart = transform.position;
            syncEnd = syncPosition;

            rotStart = transform.rotation;
            rotEnd = rot; 
        }
    }

    private void SyncedMovement()
    {
        syncTime += Time.deltaTime;
        transform.position = Vector3.Lerp(syncStart, syncEnd, syncTime / syncDelay);
        transform.rotation = Quaternion.Lerp(rotStart, rotEnd, syncTime / syncDelay);
    }
}
