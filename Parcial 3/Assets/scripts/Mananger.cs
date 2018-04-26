using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mananger : MonoBehaviour {
    [SerializeField]
    private Text textVidas;
    [SerializeField]
    private Text textPoints;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private int vidas;
    [SerializeField]
    private int puntaje;
    [SerializeField]
    private GameObject gameOverText;
    [SerializeField]
    private GameObject beginText;
    private Mananger instance;
    private bool loose = false;
    private bool begin = false;
  
    [SerializeField]
    private Player jugador;

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

    public int Puntaje
    {
        get
        {
            return puntaje;
        }

        set
        {
            puntaje = value;
        }
    }

    public bool Loose
    {
        get
        {
            return loose;
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
        beginText.SetActive(true);
        gameOverText.SetActive(false);
        UpdateScore();
        UpdateLife();
    }
	
	// Update is called once per frame
	void Update () {
        if (!begin)
        {
              if (Input.GetKeyDown(KeyCode.Space))
                {
                
                GameBegin();
                }
        }
       if (Vidas <= 0)
        {
            GameOver();
        }
        if (target != null)
        {
            transform.position = new Vector3(target.position.x + 2.58f, -1.690f, -10f);
        }
     }
    public void BajarVidas(int damage)
    {
        Vidas -= damage;
        UpdateLife();

    }
    public void SumarPuntos(int puntos)
    {
        Puntaje += puntos;
        UpdateScore();
        
    }
    void UpdateLife()
    {
        textVidas.text = "vidas:" + vidas;
    }
    void UpdateScore()
    {
        textPoints.text = "Puntaje:" + Puntaje;
    }
    public void GameOver() 
    {
        gameOverText.SetActive(true);
        jugador.Force = 0;
        loose = true;
    }
    public void GameBegin()
    {
        begin = true;
        beginText.SetActive(false);
        jugador.Force = jugador.VelocidadGuardada;
    }
}
