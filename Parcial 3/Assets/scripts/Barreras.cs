using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreras : Enemies {
    
	
	// Update is called once per frame
	void Update () {
		
	}
    public  override void DoAtCollide()
    {
        jugador.BajarVida(damage);
        jugador.Respawnear();
    }
    
}
