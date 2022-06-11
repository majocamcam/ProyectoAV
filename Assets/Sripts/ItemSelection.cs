using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelection : MonoBehaviour
{
    public GameObject juice;
    public GameObject gameboy;
    public GameObject lamp;
    public GameObject cereals;
    public GameObject tvremote;
    public GameObject donut;
    public GameObject mug;
    public GameObject launchbutton;

    public LaunchManager launchManager;


    public void DisableItems()
    {
        juice.SetActive(false);
        gameboy.SetActive(false);
        lamp.SetActive(false);
        cereals.SetActive(false);
        tvremote.SetActive(false);
        donut.SetActive(false);
        mug.SetActive(false);
        launchbutton.SetActive(false);
    }

    public void Selectjuice ()
    {
        DisableItems();
        juice.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(juice);
    }

    public void Selectgameboy()
    {
        DisableItems();
        gameboy.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(gameboy);
    }

    public void Selectlamp()
    {
        DisableItems();
        lamp.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(lamp);
    }

    public void Selectcereals()
    {
        DisableItems();
        cereals.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(cereals);
    }

    public void Selecttvremote()
    {
        DisableItems();
        tvremote.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(tvremote);
    }

    public void Selectdonut()
    {
        DisableItems();
        donut.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(donut);
    }

    public void Selectmug()
    {
        DisableItems();
        mug.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(mug);
    }
}
