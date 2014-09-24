using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    

    public float speed;
    private Vector3 movement;

	void Start () {
	
	}
	
	void Update () {
        movement = Vector3.zero;

        if(Input.GetKey(KeyCode.W)) {
            movement.z += speed;
        }

        if(Input.GetKey(KeyCode.S)) {
            movement.z -= speed;
        }

        if(Input.GetKey(KeyCode.D)) {
            movement.x += speed;
        }

        if(Input.GetKey(KeyCode.A)) {
            movement.x -= speed;
        }

        transform.Translate(movement * Time.deltaTime);
	}
}
