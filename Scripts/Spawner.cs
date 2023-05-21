using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 2;
    private float timer = 0;

    public GameObject[] items;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
        	GameObject newItem = Instantiate(items[i]);
         	newItem.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        }       
    }

    void Update()
    {
        if (timer > maxTime)
        {
            for(int i = 0; i < 5; i++)
            {
        	    GameObject newItem = Instantiate(items[i]);
         	    newItem.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            }
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
