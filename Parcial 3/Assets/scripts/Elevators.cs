using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevators : MonoBehaviour
{
    [SerializeField]
    private Transform inicial, final;
    private Transform next;

    private float elapsedTime;

    private float time;
    // Use this for initialization
    void Start()
    {
        time = 2;
        next = final;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        transform.position = Vector3.Lerp(inicial.position, next.position, elapsedTime / time);
        if (transform.position == next.position)
        {
            Again();
        }
        


    }
    private void Again()
    {
        elapsedTime = 0;
        if (next == final)
        {
            next = inicial;
            inicial = final;
        }
        else
        {
            inicial = next;
            next = final;
        }

    }
}
