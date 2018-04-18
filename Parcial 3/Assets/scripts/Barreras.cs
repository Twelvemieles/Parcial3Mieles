using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreras : Enemies {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  override void DoAtCollide()
    {
        jugador.BajarVida(damage);
        Destroy(transform.parent.gameObject);
    }
    
}
