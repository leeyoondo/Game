using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject pan;
    //[SerializeField] private GameObject hello;
    [SerializeField] private TMP_Text text;
    [SerializeField] private bool isAction = false;
    [SerializeField] private float time = 0.0f;

    void Start()
    {
        pan.SetActive(isAction);    
    }

    void Update()
    {
        if (isAction)
            time += Time.deltaTime;

        if(isAction)
        {
            pan.SetActive(isAction);
            Action();
        }
    }

    public void OnButtonClicked()
    {
        Debug.Log("실행됨");
        isAction = true;
    }

    private void Action()
    {
        if (time < 3.25f)
        {
            text.text = "플레이 해주셔서 감사합니다\r\n(Thank you for playing)";
        }
        else if (time < 6.5f)
        {
            text.text = "개발자:1116조현성\r\n1306송채우, 1412이윤도";
        }
        else if (time < 9.75f)
        {
            text.text = "맵 제작 및 기획: 1412이윤도\r\n캐릭터 제작: 1306송채우";
        }
        else if(time < 13.0f)
        {
            text.text = "캐릭터 이동: 1316송채우\r\n엔딩 제작: 1116조현성";
        }
    }
}
