using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundProperties : MonoBehaviour
{
    // 0  is Space  1 has  bought   2 has built
    public int state = 0;
    public int Price = 200;
    private GameObject HasBuyRes;
    GameObject InitPrefab;

    private void Awake()
    {
        HasBuyRes = Resources.Load<GameObject>("Prefab/HasBuy");
        InitPrefab = transform.Find("InitPrefab").gameObject;
    }

    void Start()
    {
        
    }

    public int State
    {
        get { return state; }
        set { state = value; StateChange(); }
    }

    void StateChange()
    {
        if(state == 1)
        {
            GameObject hasBuyObj = Instantiate(HasBuyRes);
            hasBuyObj.transform.SetParent(GameController._instance.currentSelectGround.transform);
            hasBuyObj.transform.localPosition = new Vector3(0, 0.5f, 0);
            hasBuyObj.name = "HasBuy";
            InitPrefab.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
