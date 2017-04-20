using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisManager : MonoBehaviour {

    // Use this for initialization
   
    public EnemyHealth enemyHealth;
    public GameObject[] m_DebrisArray;
    public Debris m_Debris;
    public Transform[] m_SpawnPoint;
    GameObject prefab;

	void Start () {
        enemyHealth = GetComponent<EnemyHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        if (enemyHealth.m_Attack)
        {
            SpawnDebris();
            Debug.Log("Debris Spawned");
        }

        //ISSUE: gives out a null reference exception 
    }

    public void SpawnDebris()
    {
        prefab = m_DebrisArray[Random.Range(0, m_DebrisArray.Length)];
        Instantiate(prefab, new Vector3(m_SpawnPoint[Random.Range(0,m_SpawnPoint.Length)].position.x,Random.onUnitSphere));
    }
}
