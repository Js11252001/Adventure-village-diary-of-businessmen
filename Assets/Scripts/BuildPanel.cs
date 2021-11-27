using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildPanel : MonoBehaviour
{
    public static BuildPanel _instance;
    GameObject BuildTypeList;
    GameObject FarmBuildList;
    GameObject PastureBuildList;
    GameObject FactoryBuildList;
    GameObject OtherBuildList;
    GameObject BuildListCloseBtn;

    Button GrassingFarmBtn;
    Button PastureBtn;
    Button FactorymBtn;
    Button OtherBtn;
    private void Awake()
    {
        _instance = this;
        BuildTypeList = transform.Find("BuildTypeList").gameObject;
        FarmBuildList = transform.Find("FarmBuildList").gameObject;
        PastureBuildList = transform.Find("PastureBuildList").gameObject;
        FactoryBuildList = transform.Find("FactoryBuildList").gameObject;
        OtherBuildList = transform.Find("OtherBuildList").gameObject;
        BuildListCloseBtn = transform.Find("BuildListCloseBtn").gameObject;
        GrassingFarmBtn = transform.Find("BuildTypeList/List/Farm").GetComponent<Button>();
        PastureBtn = transform.Find("BuildTypeList/List/Pasture").GetComponent<Button>();
        FactorymBtn = transform.Find("BuildTypeList/List/Factory").GetComponent<Button>();
        OtherBtn = transform.Find("BuildTypeList/List/Other").GetComponent<Button>();
        GrassingFarmBtn.onClick.AddListener(() =>
        {
            HideAllBuildList();
            FarmBuildList.SetActive(true);
            BuildListCloseBtn.SetActive(true);
        });
        PastureBtn.onClick.AddListener(() =>
        {
            HideAllBuildList();
            PastureBuildList.SetActive(true);
            BuildListCloseBtn.SetActive(true);
        });
        FactorymBtn.onClick.AddListener(() =>
        {
            HideAllBuildList();
            FactoryBuildList.SetActive(true);
            BuildListCloseBtn.SetActive(true);
        });
        OtherBtn.onClick.AddListener(() =>
        {
            HideAllBuildList();
            OtherBuildList.SetActive(true);
            BuildListCloseBtn.SetActive(true);
        });
        transform.Find("BuildTypeList/CloseBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            HideAll();
        });
        BuildListCloseBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            HideAllBuildList();
        });
    }

    void Start()
    {
        HideAll();
    }


    public void ShowBuildTypeList()
    {
        GameController._instance.ui_show = true;
        BuildTypeList.SetActive(true);
    }

    public void HideAll()
    {
        HideBuildTypeList();
        HideAllBuildList();
        GameController._instance.ui_show = false;
    }

    public void HideBuildTypeList()
    {
        BuildTypeList.SetActive(false);
    }

    public void HideAllBuildList()
    {
        FarmBuildList.SetActive(false);
        FactoryBuildList.SetActive(false);
        OtherBuildList.SetActive(false);
        PastureBuildList.SetActive(false);
        BuildListCloseBtn.SetActive(false);
    }
}      
