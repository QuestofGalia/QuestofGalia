using UnityEngine;
using System.Collections;

public class level_change : MonoBehaviour {

    public int nextLevel;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel(nextLevel);
        }
    }
}
