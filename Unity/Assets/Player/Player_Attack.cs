using UnityEngine;
using System.Collections;

public class Player_Attack : MonoBehaviour {

    public float range = 1.5f;
    public float cooldown = 0.5f;
    public int attackDamage = -25;
    private float attackTime = 0;


    void MeleeAttack()
    {
        if (Time.time > attackTime)
        {
            attackTime = Time.time + cooldown;
            Collider[] coll = Physics.OverlapSphere(transform.position, range);
            foreach (Collider hit in coll) {
                if(hit && hit.tag == "Monster") {
                    if(Vector3.Distance(hit.transform.position, transform.position) <= range)
                    {
                        hit.SendMessage("AddjustCurrentHealth", attackDamage);
                    }
                }
            }
        }
    }
    

	

	void Update () {
        if (Input.GetButtonDown("Fire1"))
            MeleeAttack();
	}
}
