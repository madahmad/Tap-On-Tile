using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    // The Target
    public Transform target;
    
    void LateUpdate () {
        transform.position = new Vector3(target.position.x,
                                         transform.position.y,
                                         transform.position.z);
    }
}
