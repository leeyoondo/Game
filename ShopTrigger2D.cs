using UnityEngine;

public class ShopTrigger2D : MonoBehaviour
{
    public GameObject shopUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 상점 구역에 들어옴");
            shopUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 상점 구역에서 나감");
            shopUI.SetActive(false);
        }
    }
}
//컴포넌트에서 오브젝트 잘 넣었는지 확인 해야함