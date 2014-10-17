using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

	// Use this for initialization
    public float health = 50;
    public float resetAfterDeathTime = 5;

    private Player playerMovement;
    private float timer;
    private bool playerDead;


    void Awake()
    {
        playerMovement = GetComponent<Player>();

    }
	

	void Update () {

        if (health <= 0f)
        {
            if (!playerDead)
            {
                PlayerDying();
            }
            else
            {
                PlayerDead();
                LevelReset();
            }
                
        }
	}

    void PlayerDying()
    {
        playerDead = true;
    }

    void PlayerDead()
    {
        playerMovement.enabled = false;
    }

    void LevelReset()
    {
        timer += Time.deltaTime;

        if (timer >= resetAfterDeathTime)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
