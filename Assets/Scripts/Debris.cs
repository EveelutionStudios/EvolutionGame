using System.Collections;
using System;
using UnityEngine;

public class Debris : MonoBehaviour {

    public enum TrashType
    {
        Biodegradable,
        Nonbiodegradable,
        Recyclable
    };

    // Use this for initialization
    public string m_TrashName;
    public GameObject m_Trash;
    public  TrashType m_TrashType;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    public Debris(string trashName, GameObject trash, TrashType trashType)
    {
        m_TrashName = trashName;
        m_Trash = trash;
        m_TrashType = trashType;
    }
}
