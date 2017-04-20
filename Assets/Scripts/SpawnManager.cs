using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    // Use this for initialization
    public GameObject[] m_Enemy;
    public EnemyHealth m_EnemyHealth;
    public Transform m_SpawnLocation;
    GameObject prefab;

	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {

        if (m_EnemyHealth.m_CurrentHealth <= 0 && m_EnemyHealth.m_IsDead)
        {
            Debug.Log(m_EnemyHealth.m_CurrentHealth);
            Spawn();
        }

	}

    public void Spawn()
    {
        prefab = m_Enemy[Random.Range(0, m_Enemy.Length)];
        Instantiate(prefab, m_SpawnLocation.position, m_SpawnLocation.rotation);
        prefab.tag = "Enemy";
        m_EnemyHealth.m_IsDead = false;
        m_EnemyHealth.m_CurrentHealth = m_EnemyHealth.m_StartingHealth;
    }
}
