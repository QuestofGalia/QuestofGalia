using UnityEngine;
using System.Collections;

public class key : MonoBehaviour {

    private bool t;
    private Transform target = null;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            target = other.transform;
            Player player = (Player)target.GetComponent("Player");
            Debug.Log("Information to player");
            t = true;
            player.hasKey(t);
            Debug.Log("Destroy myself");
            Destroy(gameObject);
        }
    }
}
