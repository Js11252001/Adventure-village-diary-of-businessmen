using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController _instance;
    public GroundProperties currentSelectGround;
    public bool ui_show;
    private GameObject SelectGroundTip;

    private void Awake()
    {
        _instance = this;
        ui_show = false;
        SelectGroundTip = GameObject.Find("SelectGroundTip");
    }

    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
        RaycastHit hit;
        if(!ui_show)
        {
            currentSelectGround = null;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                //Detect collision with the ground
                if (hit.collider.tag == "Ground")
                {
                    currentSelectGround = hit.collider.GetComponent<GroundProperties>();
                    SelectGroundTip.transform.position = hit.collider.transform.position;
                    SelectGroundTip.transform.localScale = new Vector3(hit.collider.transform.localScale.x / 3, 1, hit.collider.transform.localScale.z / 3);
                }
            }
        }

        if(Input.GetMouseButtonDown(0))
        {
            if( currentSelectGround != null )
            {
                if( currentSelectGround.State == 0 )
                {
                    BuyGroundWin._instance.Show();
                    //buy land tipWindow

                }
                else if( currentSelectGround.State == 1 )
                {
                    BuildPanel._instance.Show();
                    //TODO show buildWindow or creat constructor
                }
            }
        }
    }
}
