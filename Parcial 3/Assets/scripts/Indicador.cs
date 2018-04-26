using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicador : Enemies {

    [SerializeField]
    private Respawner respawner;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public override void DoAtCollide()
    {
        
    }
    protected override void OnTriggerEnter(Collider other)
    {
        IPlayer playeringuis = other.gameObject.transform.GetComponent<IPlayer>();
        if (playeringuis != null)
        {
            DoAtTriggerCollide();
        }
    }
    
    public override void DoAtTriggerCollide()
    {
         
            respawner.Respawnear();
        
    }

}
