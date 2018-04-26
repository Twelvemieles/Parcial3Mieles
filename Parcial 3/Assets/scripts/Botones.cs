using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botones : MonoBehaviour {

    public string actualScene;
  



    public void BotonRepetir ()
    {
        SceneManager.LoadScene(actualScene);

    }


   




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
