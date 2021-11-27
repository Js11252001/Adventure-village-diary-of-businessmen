using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDictionary : MonoBehaviour
{
    public static GameDictionary _instance;
    public Dictionary<int, GroundClass> groundDic = new Dictionary<int, GroundClass>();
    public TextAsset groundData;
    // Start is called before the first frame update
    private void Awake()
    {
        _instance = this;
        ReadGroundData();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ReadGroundData()
    {
        string str = groundData.ToString();
        string[] PerGroundStrArray = str.Split('\n');
        foreach (string item in PerGroundStrArray)
        {
            string[] proArray = item.Split('|');
            groundDic.Add(int.Parse(proArray[0]), 
                new GroundClass(int.Parse(proArray[0]), proArray[1], proArray[2], int.Parse(proArray[3])));

        }
    }
}
