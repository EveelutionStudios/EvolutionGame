

using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    // Use this for initialization
    GameObject enemy;
    public int m_StartingHealth;            // initial health of the enemy spawned                                                              
    public int m_CurrentHealth;             // the updated health of the enemy                                                                
    public int m_Damage;


    public bool m_IsDead;                   //boolean checking if the current enemy spawned is dead or not                                                                      
    public bool m_Attack;


	void Start () {
       m_CurrentHealth = m_StartingHealth;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(m_Damage);
        }
	}

    public void TakeDamage(int amount)      //Function that subtracts health from the enemy health and is accessed every tap of the player                                                       
    {
        if (m_IsDead)                       // checker if the enemy is dead or alive                                                                        
        {
            return;                         //if yes, it just returns out of this if and continues with life :)                                                 
        }
            
        m_CurrentHealth -= amount;          //equation for deducting health (amount) from the current health                                                            
        m_Attack = false;

        if (m_CurrentHealth <= 0)           // checks the health if it's less than or equal to zero                                                            
        {
            Death();                       // if it is less than or equal to zero, it calls on the Death function                                                 
        }
       
    }

    public void Death()                    //function that flags the death of an enemy and destroys that game object                                                        
    {
        m_IsDead = true;
        Destroy(GameObject.FindWithTag("Enemy"));
        Debug.Log("You Passed Here");
        m_StartingHealth++;
        
    }
}
