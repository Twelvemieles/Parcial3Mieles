using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies : MonoBehaviour, IEnemy {
    [SerializeField]
    protected int damage;
    protected IPlayer jugador;
    // Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void OnCollisionEnter(Collision collision)
    {
        jugador = collision.gameObject.transform.GetComponent<IPlayer>();
        if (jugador != null)
        {
            DoAtCollide();
            
            
        }
    }
    public abstract void DoAtCollide();
    

}
