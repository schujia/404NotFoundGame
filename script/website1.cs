using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class website1 : MonoBehaviour
{
    // Use this for initialization
    public GameObject button1;

    
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
        Application.OpenURL("https://notfound.org/en");
    }
}
