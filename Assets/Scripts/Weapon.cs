using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Weapon : MonoBehaviour
{
    public GameObject handedPickaxe;
    public GameObject handedClup;
    public GameObject handedAxe;
    public GameObject handedDagger;
    public GameObject StartCanvas;
    public static bool axe;
    public static bool clup;
    public static bool dagger;
    public static bool picaxe;
    public static bool selected;



    void Start()
    {
        
        StartCanvas.SetActive(true);
        
}

    // Update is called once per frame
    void Update()
    {
       

    }
    public void AxeSelected()
    {
        handedAxe.SetActive(true);
        StartCanvas.SetActive(false);
        Time.timeScale = 1;
        axe = true;
        selected = true;
        



    }
    public void PickaxeSelected()
    {
        handedPickaxe.SetActive(true);
        StartCanvas.SetActive(false);
        Time.timeScale = 1;
        picaxe = true;
        selected = true;


    }
    public void DaggerSelected()
    {
        handedDagger.SetActive(true);
        StartCanvas.SetActive(false);
        Time.timeScale = 1;
        dagger = true;
        selected = true;


    }
    public void ClupSelected()
    {
        handedClup.SetActive(true);
        StartCanvas.SetActive(false);
        Time.timeScale = 1;
        clup = true;
        selected = true;


    }
}
