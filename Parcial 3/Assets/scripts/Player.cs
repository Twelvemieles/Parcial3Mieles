using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer {
    [SerializeField]
    private Mananger mananger;
    
    [SerializeField]
    private float force;
    [SerializeField]
    private float jumpForce;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(force, 0, 0);
        // GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.VelocityChange );
        //GetComponent<Rigidbody>().velocity = new Vector3(force,-3,0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.up * jumpForce, ForceMode.Impulse );
        }
    }
    public void BajarVida(int damage)
    {
        mananger.BajarVidas(damage);
    }
}
