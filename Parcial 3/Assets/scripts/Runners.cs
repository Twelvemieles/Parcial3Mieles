using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runners : MonoBehaviour {
    [SerializeField]
    private Transform inicial, final;
    

    private float elapsedTime;

    private float time;
    // Use this for initialization
    void Start () {
        time = 2;
    }
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;

        transform.position = Vector3.Lerp(inicial.position, final.position, elapsedTime / time);
        if (transform.position == final.position)
        {
            
        }
    }
    public void Begin()
    {
        elapsedTime = 0;
        
    }
}
