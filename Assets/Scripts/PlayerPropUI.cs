using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPropUI : MonoBehaviour
{
    public static PlayerPropUI _instance;
    public Text CoinText;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        UpdateCoinUI();
    }
    public void UpdateCoinUI()
    {
        CoinText.text = PlayerProp._instance.Coin.ToString();
    }
}
