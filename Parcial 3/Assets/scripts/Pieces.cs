using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour {
    [SerializeField]
    private Transform deshabilitador;
    [SerializeField]
    private bool activo;
    [SerializeField]
    private Transform beginPieces;
    [SerializeField]
    private Transform pool;
    public bool Activo
    {
        get
        {
            return activo;
        }

        set
        {
            activo = value;
        }
    }

    // Use this for initialization
    void Start () {
        activo = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
           if(activo == false)
        {
            transform.position = pool.position;
        }
        if(transform.position.x < deshabilitador.position.x)
          {
             activo = false;
         }
    }
    public void habilitar()
    {
        activo = true;
        transform.position = beginPieces.position;
       // print("activo ="+ Activo);
    }
}
