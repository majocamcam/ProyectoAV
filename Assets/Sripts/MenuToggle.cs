using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuToggle : MonoBehaviour
{
    public Animator menuanim;
    bool visible = true;
    public Image targetimage;
    public Button targetbutton;
    public Sprite downpress, downidle, uppress, upidle; 

    private void Start()
    {
        visible = false;
        menuanim.Play("Hide");

        targetimage.sprite = downidle;
        SpriteState pressedstate;
        pressedstate.pressedSprite = downpress;
        targetbutton.spriteState = pressedstate;

        GetComponentInChildren<ItemSelection>().DisableItems();


        if (PlayerPrefs.GetInt("level") <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Toggle ()
    {
        visible = !visible;

        if (visible)
        {
            menuanim.Play("Show");
            targetimage.sprite = upidle;
            SpriteState pressedstate;
            pressedstate.pressedSprite = uppress;
            targetbutton.spriteState = pressedstate;
        }
        else 
       {
            menuanim.Play("Hide");
            targetimage.sprite = downidle;
            SpriteState pressedstate;
            pressedstate.pressedSprite = downpress;
            targetbutton.spriteState = pressedstate;
        }
    }

    public void OnlyHide()
    {
        if (visible)
        {
            Toggle();
        }
    }


}
