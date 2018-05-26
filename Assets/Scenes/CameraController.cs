using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum Direction {
    Neutral, Left, Right
}
public class CameraController : MonoBehaviour {

    Direction lastDirection = Direction.Neutral;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("q")) {
            lastDirection = Direction.Left;
        }else if (Input.GetKeyDown("e")) {
            lastDirection = Direction.Right;
        } else if (Input.GetKeyUp("q") || Input.GetKeyUp("e")) {
            lastDirection = Direction.Neutral;
        }
        switch (lastDirection) {
            case Direction.Left : transform.Rotate(0, transform.rotation.x - 1, 0); break;
            case Direction.Right: transform.Rotate(0, transform.rotation.x + 1, 0); break;
        }
        if (Input.GetKey("r")) {

            transform.rotation = transform.parent.gameObject.transform.rotation;
        }
        
        
    }
}
