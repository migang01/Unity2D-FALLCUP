using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 2;
    private float timer = 0;

    // could've used "public GameObject[] items 
    public GameObject Orange;
    public GameObject Lemon;
    public GameObject Peach;
    public GameObject Coffee;
    public GameObject Rock;

    void Start()
    {
        // could've used "for" statement instead of typing every single items
        // for(int i = 0; i < 6; i++)
        //{
        //	GameObject newOrange = Instantiate(items[Random.Range(0, 6)]);
        // 	newItem.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        // 	Destroy(newItem, 200);
        //}

        GameObject newOrange = Instantiate(Orange);
        newOrange.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        GameObject newLemon = Instantiate(Lemon);
        newLemon.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        GameObject newPeach = Instantiate(Peach);
        newPeach.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        GameObject newCoffee = Instantiate(Coffee);
        newCoffee.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
        GameObject newRock = Instantiate(Rock);
        newRock.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);

    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newOrange = Instantiate(Orange);
            newOrange.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            Destroy(newOrange, 200);

            GameObject newLemon = Instantiate(Lemon);
            newLemon.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            Destroy(newLemon, 200);

            GameObject newCoffee = Instantiate(Coffee);
            newCoffee.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            Destroy(newCoffee, 200);

            GameObject newPeach = Instantiate(Peach);
            newPeach.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            Destroy(newPeach, 200);

            GameObject newRock = Instantiate(Rock);
            newRock.transform.position = transform.position + new Vector3(Random.Range(-2, 2), Random.Range(0, 10), 0);
            Destroy(newRock, 200);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}