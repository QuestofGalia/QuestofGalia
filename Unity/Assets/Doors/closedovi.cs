using UnityEngine;
using System.Collections;

public class closedovi : MonoBehaviour {

    public Player player;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && player.gotKey == true)
        {
            Destroy(gameObject);
        }
    }
    
}
