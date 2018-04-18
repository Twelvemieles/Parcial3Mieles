using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] pieces;
    [SerializeField]
    private Transform beginPieces;
    private Respawner instance;

    

    // Use this for initialization
    void Start () {
        foreach (GameObject element in pieces)
        {
            GameObject obj = Instantiate(element);
            obj.SetActive(false);
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
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
    public void Respawnear()
    {
        int azar = Random.Range(0, pieces.Length);
        if (!pieces[azar].activeInHierarchy)
        {
            pieces[azar].transform.position = beginPieces.transform.position;
            pieces[azar].SetActive(true);

            print("si mi pae respauneee");
            print(azar);
        }
        else
        {
            Respawnear();
            print("nelas panelas nuai respaun");
        }
    }
}
