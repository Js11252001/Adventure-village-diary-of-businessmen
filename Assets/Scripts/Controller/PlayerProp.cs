using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProp : MonoBehaviour
{
    public static PlayerProp _instance;
    private void Awake()
    {
        _instance = this;
    }

    private int coin = 1000;
    public int Coin
    {
        get { return coin; }
        //update coin UI
        set { coin = value; PlayerPropUI._instance.UpdateCoinUI(); }
    }
}
