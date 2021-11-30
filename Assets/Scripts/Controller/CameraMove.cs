using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float moveSpeed = 0.15f;

    private Vector3 minPos = new Vector3(-14,14,-12);
    private Vector3 maxPos = new Vector3(11, 14, 15);
    private Vector3 InitBuildPos = new Vector3(0, 14, 0);

    public Vector3 MaxPos
    { 
        get { return maxPos; }
        set { maxPos = value; }
    }

    public Vector3 MinPos
    {
        get { return minPos; }
        set { minPos = value; }
    }

    void Start()
    {
        transform.position = InitBuildPos;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x < 0 && transform.position.x < MinPos.x) x = 0;
        if (x > 0 && transform.position.x > MaxPos.x) x = 0;
        if (z < 0 && transform.position.z < MinPos.z) z = 0;
        if (z > 0 && transform.position.z > MaxPos.z) z = 0;
        transform.position = new Vector3(transform.position.x + x * moveSpeed, transform.position.y, transform.position.z + z * moveSpeed);
    }
}
