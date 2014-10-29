using UnityEngine;
using System.Collections;

public class openovi : MonoBehaviour {



	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Destroy(gameObject);
		}
	}


}
