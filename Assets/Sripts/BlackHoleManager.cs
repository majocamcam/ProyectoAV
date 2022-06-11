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
    public GameObject Earth;
    public GameObject Overlay;
    public MenuToggle Menu;
    public GameObject GameOver;

    private void Start()
    {
        if (PlayerPrefs.GetInt("level") > 0)
        {
            SetLevel(PlayerPrefs.GetInt("level"));
        }
    }

    void Addlevel()
    {
        if (blackholelevel == maxlevel)
        {
            return;
        }
        SetLevel(blackholelevel + 1);
    }

    void SetLevel(int level)
    {

        blackholelevel = level;
        PlayerPrefs.SetInt("level", blackholelevel);

        float ratio = (float)blackholelevel / maxlevel;
        float scale = Mathf.Lerp(minscale, maxscale, ratio);
        this.transform.localScale = new Vector3(scale, scale, scale);

        var shape = particlered.shape;
        shape.radius = Mathf.Lerp(minradius, maxradius, ratio);
        var shape2 = particlegreen.shape;
        shape2.radius = Mathf.Lerp(minradius, maxradius, ratio);
        var shape3 = particleblue.shape;
        shape3.radius = Mathf.Lerp(minradius, maxradius, ratio);

        if (blackholelevel == maxlevel)
        {
            Overlay.SetActive(true);
            Earth.SetActive(true);
            Menu.OnlyHide();
            StartCoroutine(DelayedGameOverScreen());
        }
    }

    private IEnumerator DelayedGameOverScreen()
    {
        yield return new WaitForSeconds(5.30f);
        GameOver.SetActive(true);
    }

    void Looselevel()
    {
        blackholelevel = blackholelevel - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Addlevel();
        blackholeanim.Play("Eat");
        Destroy(other.gameObject, 0); 
    }

}
