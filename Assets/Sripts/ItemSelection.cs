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
        launchManager.Selectlaunchitem(juice, BlackHoleManager.targetDesiredItem == throwItemType.juice);
    }

    public void Selectgameboy()
    {
        DisableItems();
        gameboy.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(gameboy, BlackHoleManager.targetDesiredItem == throwItemType.console);
    }

    public void Selectlamp()
    {
        DisableItems();
        lamp.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(lamp, BlackHoleManager.targetDesiredItem == throwItemType.lamp);
    }

    public void Selectcereals()
    {
        DisableItems();
        cereals.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(cereals, BlackHoleManager.targetDesiredItem == throwItemType.cereals);
    }

    public void Selecttvremote()
    {
        DisableItems();
        tvremote.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(tvremote, BlackHoleManager.targetDesiredItem == throwItemType.remote);
    }

    public void Selectdonut()
    {
        DisableItems();
        donut.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(donut, BlackHoleManager.targetDesiredItem == throwItemType.donut);
    }

    public void Selectmug()
    {
        DisableItems();
        mug.SetActive(true);
        launchbutton.SetActive(true);
        launchManager.Selectlaunchitem(mug, BlackHoleManager.targetDesiredItem == throwItemType.mug);
    }
}
