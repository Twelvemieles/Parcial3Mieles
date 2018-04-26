using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorRunner : MonoBehaviour {

    [SerializeField]
    private Runners runner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        IPlayer playeringuis = other.gameObject.transform.GetComponent<IPlayer>();
        if (playeringuis != null)
        {
            runner.Begin();
        }
    }
        }
