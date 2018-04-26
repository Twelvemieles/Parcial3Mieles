using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {

    [SerializeField]
    private Pieces[] pieces;

    [SerializeField]
    private Transform pool;
    
    
    private Respawner instance;

    

    // Use this for initialization
    void Start () {
        foreach (Pieces element in pieces)
        {
            element.transform.position = pool.position;
           
            element.Activo = false;
            
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

    }
    public void Respawnear()
    {
        int azar = Random.Range(0, 3);
        

        if (pieces[azar].Activo == false)
        {
            pieces[azar].habilitar();
            
           

           // print("si mi pae respauneee");
           // print(azar);
        }
        else
        {
            Respawnear();
           // print("nelas panelas nuai respaun");
        }
    }
}
