using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    [SerializeField]
    private Mananger mananger;

    [SerializeField]
    private float force;
    [SerializeField]
    private Transform respawnPlayer;
    [SerializeField]
    private float jumpForce;
    private bool onFloor;
    private float velocidadGuardada;

    public float Force
    {
        get
        {
            return force;
        }

        set
        {
            force = value;
        }
    }

    public float VelocidadGuardada
    {
        get
        {
            return velocidadGuardada;
        }

        set
        {
            velocidadGuardada = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        VelocidadGuardada = Force;
        Force = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Force, 0, 0);
        if (!mananger.Loose)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Force = 0;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                Force = VelocidadGuardada;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (onFloor)
                {
                    GetComponent<Rigidbody>().AddForce(transform.up * jumpForce, ForceMode.Impulse);
                }
            }
        }
    }
    public void BajarVida(int damage)
    {
        mananger.BajarVidas(damage);
    }
    public void Respawnear()
    {
        transform.position = new Vector3 (transform.position.x,respawnPlayer.position.y);
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = false;
        }
    }
    public void SumarPuntaje(int puntos)
    {
        mananger.SumarPuntos(puntos);
    }
   
}
