using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject sonZemin;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            zeminSpawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void zeminSpawn()
    {
        Vector3 direction;
        if(Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        sonZemin = Instantiate(sonZemin, sonZemin.transform.position + direction, sonZemin.transform.rotation);
    }
}
