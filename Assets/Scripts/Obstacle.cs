using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    // Movement Speed (0 means don't move)
    public float speed = 0;
    
    // Switch Movement Direction every x seconds
    public float switchTime = 2;

    void Start() {
        // Initial Movement Direction
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        
        // Switch every few seconds
        InvokeRepeating("Switch", 0, switchTime);
    }
    
    void Switch() {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
