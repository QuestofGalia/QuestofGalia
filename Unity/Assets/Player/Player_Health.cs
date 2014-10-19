using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

	// Use this for initialization
    public float currentHealth = 50;
    public float maxHealth = 50;
    public float resetAfterDeathTime = 5;
    public float healthBarLength;

    private Player playerMovement;
    private float timer;
    private bool playerDead;


    void start()
    {
        healthBarLength = Screen.width / 2;
    }
    void Awake()
    {
        playerMovement = GetComponent<Player>();

    }
	
    void OnGUI() {
        GUI.Box(new Rect(10,10, healthBarLength, 20), currentHealth + "/" + maxHealth);
    }

	void Update () {
        AddjustCurrentHealth(0);

        if (currentHealth <= 0f)
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

    public void AddjustCurrentHealth(int adj)
    {
        currentHealth += adj;

        if (currentHealth < 0)
            currentHealth = 0;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        if (maxHealth < 1)
            maxHealth = 1;

        healthBarLength = (Screen.width / 2) * (currentHealth / (float)maxHealth);

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
