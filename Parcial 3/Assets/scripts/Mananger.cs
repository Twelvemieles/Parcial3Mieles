using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mananger : MonoBehaviour {
    [SerializeField]
    private Text textVidas;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private int vidas;
    private Mananger instance;

    public int Vidas
    {
        get
        {
            return vidas;
        }

        set
        {
            vidas = value;
        }
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
    // Use this for initialization
    void Start () {
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            transform.position = new Vector3(target.position.x + 2.58f, -1.690f, -10f);
        }
     }
    public void BajarVidas(int damage)
    {
        Vidas -= damage;
        UpdateScore();
    }
    void UpdateScore()
    {
        textVidas.text = "vidas:" + vidas;
    }
}
