using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildButton : MonoBehaviour
{
    Button btn;
    public int id = -1;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => 
        {
            ClickThis();
        });
    }

    void ClickThis()
    {
        if (PlayerProp._instance.Coin >= GameDictionary._instance.groundDic[id].price)
        {
            //According to the id, get the resName from groundDictionary
            GameObject res = Resources.Load<GameObject>("Ground/" + GameDictionary._instance.groundDic[id].resName);
            GameObject Gobj = Instantiate(res);
            GroundProperties currentGround = GameController._instance.currentSelectGround;
            Gobj.transform.position = currentGround.transform.position;
            Gobj.transform.SetParent(currentGround.transform);
            Gobj.transform.localScale = new Vector3(1, 1, 1);

            currentGround.State = 2;
            currentGround.GroundId = id;

            BuildPanel._instance.HideAll();
            Gobj.name = "Build";
            PlayerProp._instance.Coin -= GameDictionary._instance.groundDic[id].price;
        }
        else
        {
            Tip._instance.ShowCoinNotEnough();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
