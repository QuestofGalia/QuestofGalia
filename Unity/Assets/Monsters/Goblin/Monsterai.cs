using UnityEngine;
using System.Collections;

public class Monsterai : MonoBehaviour {

    public GameObject Player;
    private Transform target = null;
    public int MovSpeed;
    public float minDist;
    public int attackDamage = -5;
    public float cooldown = 1.5f;
    public float attackTime = 0;
    public float range = 1.3f;


	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") target = other.transform;
        Debug.Log("Löyty");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") target = null;
        Debug.Log("Katosi");
    }


	// Update is called once per frame
	void Update () {
        if (target == null) return;
        
        transform.LookAt(target);
            
        float distance = Vector3.Distance(transform.position, target.position);
        Debug.Log("Välimatka saatu");
        bool tooClose = distance < minDist;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        Debug.Log("Kohta lähtee");
        transform.Translate(direction * MovSpeed * Time.deltaTime);
        Debug.Log("Liikutaan");
        
      if(attackTime > 0)
            attackTime -= Time.deltaTime;

        if (attackTime < 0)
            attackTime = 0;

        if (attackTime == 0)
        {
            if (Vector3.Distance(transform.position, target.position) <= range)
            {
                Player_Health eh = (Player_Health)target.GetComponent("Player_Health");
                eh.AddjustCurrentHealth(attackDamage);
            }
            attackTime = cooldown;
        }
}
}
