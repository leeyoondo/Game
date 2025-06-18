using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float delay;
    public GameObject blockPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        delay = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(delay >= 5f)
        {
            StartCoroutine(Creat_cube());
            
        }
        delay += Time.deltaTime;

    }

    IEnumerator Creat_cube()
    {
        Instantiate(blockPrefab, new Vector3(688.6f, 326.25f, 0f), Quaternion.identity);
        delay = 0f;
        yield return null;
    }
}
