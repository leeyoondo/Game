using UnityEngine;
using UnityEngine.EventSystems;
public class touch : MonoBehaviour
{
    int money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        money++;
        Debug.Log(money);

    }
}
