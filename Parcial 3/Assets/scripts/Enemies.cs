using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies : MonoBehaviour, IEnemy
{
    [SerializeField]
    protected int damage;
    [SerializeField]
    protected int puntos;
    [SerializeField]
    protected Player jugador;
    // Use this for initialization

    protected virtual void Start()
    {
        puntos = 1;
        jugador = GameObject.Find("player").GetComponent <Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "puntuador")
        {
            //print("choque punt");
            
                DoAtTriggerCollide();
            
        }
    }
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            DoAtCollide();


        }
    }
    public abstract void DoAtCollide();
    public virtual void DoAtTriggerCollide()
    {

       // print("sum punt");
        jugador.SumarPuntaje(puntos);



    }
}



