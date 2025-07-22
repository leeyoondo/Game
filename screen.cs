using UnityEngine;

public class screen : MonoBehaviour
{
    public GameObject targetPanel; 
    private void Start()
    {
        targetPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            targetPanel.SetActive(true);
        }
    }
}
