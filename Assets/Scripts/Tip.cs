using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    public static Tip _instance;
    Text Content;
    Button CloseBtn;

    private void Awake()
    {
        _instance = this;
        Content = transform.Find("Content").GetComponent<Text>();
        CloseBtn = transform.Find("CloseBtn").GetComponent<Button>();
        gameObject.SetActive(false);
        CloseBtn.onClick.AddListener(Hide);
    }

    public void ShowCoinNotEnough()
    {
        Content.text = "金币不够";
        Show();
    }

    void Show()
    {
        gameObject.SetActive(true);
        GameController._instance.ui_show = true;
    }

    void Hide()
    {
        gameObject.SetActive(false);
        GameController._instance.ui_show = false;
    }
}
