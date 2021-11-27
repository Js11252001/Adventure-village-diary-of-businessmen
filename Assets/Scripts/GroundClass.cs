using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundClass
{
    public int id;
    public string resName;
    public string _name;
    public int price;
    public GroundClass(int id, string resName, string name, int price)
    {
        this.id = id;
        this.resName = resName;
        this._name = name;
        this.price = price;
    }
}
