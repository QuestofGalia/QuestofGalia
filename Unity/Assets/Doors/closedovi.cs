using UnityEngine;
using System.Collections;

public class closedovi : MonoBehaviour {

    private Transform target = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.transform;
            Player player = (Player)target.GetComponent("Player");

            if(player.getKey() == 1)
                Destroy(gameObject);
        }

    }
    
}
