using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleManager : MonoBehaviour
{
    int blackholelevel = 0;
    int maxscale = 8;
    int minscale = 1;
    int maxlevel = 10;
    public ParticleSystem particlered, particleblue, particlegreen;
    public Animator blackholeanim;
    float minradius = 3;
    float maxradius = 10; 


    void Addlevel()
    {
        blackholelevel = blackholelevel + 1;
        float ratio = (float)blackholelevel / maxlevel;
        float scale = Mathf.Lerp(minscale, maxscale, ratio);
        this.transform.localScale = new Vector3(scale, scale, scale);
        
        var shape = particlered.shape;
        shape.radius = Mathf.Lerp(minradius, maxradius, ratio);
        var shape2 = particlegreen.shape;
        shape2.radius = Mathf.Lerp(minradius, maxradius, ratio);
        var shape3 = particleblue.shape;
        shape3.radius = Mathf.Lerp(minradius, maxradius, ratio);
        
    }

    void Looselevel()
    {
        blackholelevel = blackholelevel - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("UOCH");
        Addlevel();
        blackholeanim.Play("Eat");
        Destroy(other.gameObject, 0); 
    }

}
