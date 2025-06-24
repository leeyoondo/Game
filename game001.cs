using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Cube_moving : MonoBehaviour
{
    int Collision_Count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collision_Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Collision_Count == 1)
            Is_Moving();
        else if (Collision_Count == 2) { 
            StartCoroutine(Destory_Box());
        }
    }

    private void Is_Moving()
    {
        transform.position += new Vector3(3f,0f,0f) * Time.deltaTime;
    }

    IEnumerator Destory_Box()
    {
        Destroy(gameObject);
        yield return null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collision_Count++;
    }
}