using UnityEngine;
using System.Collections;

public class Monster_Health : MonoBehaviour {

    // Use this for initialization
    public float health = 10;
    public float resetAfterDeathTime = 1.5f;

    private Monsterai monsterMovement;
    private float timer;
    private bool monsterDead;


    void Awake()
    {
        monsterMovement = GetComponent<Monsterai>();
    }


    void Update()
    {

        if (health <= 0f)
        {
            if (!monsterDead)
            {
                monsterDying();
            }
            else
            {
                MonsterDead();
            }

        }
    }

    void monsterDying()
    {
        monsterDead = true;
    }

    void MonsterDead()
    {
        monsterMovement.enabled = false;
        timer += Time.deltaTime;

        if (timer >= resetAfterDeathTime)
        {
            Destroy(gameObject);
        }
    }
}