using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    

    public float speed;
    private Vector3 movement;

	void Start () {
	
	}
	
	void Update () {
        movement = Vector3.zero;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            movement.z += speed;
        }


        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movement.z -= speed;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += speed;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= speed;
        }

        transform.Translate(movement * Time.deltaTime);
	}
}
