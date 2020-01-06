using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class webSite2 : MonoBehaviour
{
    // Use this for initialization
    public GameObject button2;


    void Start()
    {

    }
    void Awake()
    {
        Button button = gameObject.GetComponent<Button>();

        button.onClick.AddListener(btClick);//添加监听器用于监听按键事件，并回调函数
    }
    // Update is called once per frame
    void Update()
    {
    }
    void btClick()
    {
        print("Button Click");
        Application.OpenURL("https://www.404notfoundfilm.com/");
    }
}
