using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPanel : MonoBehaviour
{
    public static BuildPanel _instance;
    public GameObject[] arr;

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        Hide();
    }

    void Update()
    {
        
    }
    
    public void Show()
    {
        GameController._instance.ui_show = true;
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        GameController._instance.ui_show = false;
        this.gameObject.SetActive(false);
    }

    public void showFarm()
    {
        arr[0].SetActive(true);
    }
}
