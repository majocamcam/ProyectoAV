using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleManager : MonoBehaviour
{
    int blackholelevel = 0;
    int maxscale = 5;
    int minscale = 1;
    int maxlevel = 10;


    void Addlevel()
    {
        blackholelevel = blackholelevel + 1;
        float ratio = (float)blackholelevel / maxlevel;
        float scale = Mathf.Lerp(minscale, maxscale, ratio);
        this.transform.localScale = new Vector3(scale, scale, scale);
    }

    void Looselevel()
    {
        blackholelevel = blackholelevel - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("UOCH");
        Addlevel();

        Destroy(other.gameObject, 0); 
    }

}
