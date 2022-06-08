using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public Animator menuanim;
    bool visible = true;

    private void Start()
    {
        visible = false;
        menuanim.Play("Hide");
    }

    public void Toggle ()
    {
        visible = !visible;

        if (visible)
        {
            menuanim.Play("Show");
        }
        else 
       {
            menuanim.Play("Hide");
        }
    }


}
