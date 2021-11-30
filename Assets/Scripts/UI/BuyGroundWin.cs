using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyGroundWin : MonoBehaviour
{
    public static BuyGroundWin _instance;

    Button CloseBtn;
    Button BuyBtn;

    private void Awake()
    {
        _instance = this;
        CloseBtn = transform.Find("CloseBtn").GetComponent<Button>();
        BuyBtn = transform.Find("BuyBtn").GetComponent<Button>();

        CloseBtn.onClick.AddListener(() =>
        {
            Hide();
        });

        BuyBtn.onClick.AddListener(() =>
        {
            if (PlayerProp._instance.Coin >= GameController._instance.currentSelectGround.Price)
            {
                PlayerProp._instance.Coin -= GameController._instance.currentSelectGround.Price;
                GameController._instance.currentSelectGround.State = 1;
            }
            else
            {
                //TODO coin is not enough
                Tip._instance.ShowCoinNotEnough();
            }
            Hide();
        });
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
        gameObject.SetActive(true);
        GameController._instance.ui_show = true;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        GameController._instance.ui_show = false;
    }
}
