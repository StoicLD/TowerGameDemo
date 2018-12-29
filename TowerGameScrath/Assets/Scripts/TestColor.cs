using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColor : MonoBehaviour
{
    // Start is called before the first frame update
    Color cubecolor;
    Renderer rend;
    Material mat;
    public float growdir;
    public float duration;
    public Color origincolor;
    public Color changeColor;
    void Start()
    {
        growdir = 1.0f;
        duration = .0f;
        rend = GetComponent<Renderer>();
        mat = rend.material;
        origincolor = mat.color;
    }

    // Update is called once per frame
    void Update()
    {
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //rend.material.color = Color.Lerp(rend.material.color, mycolor, lerp);
        //Fade();
        if (Input.GetKeyUp("w"))
        {
            StartCoroutine(controlFade());
        }
        else if (Input.GetKeyDown("d"))
            print("press 'd'");

    }

    IEnumerator controlFade()
    {
        while (true)
        {
            Color c = rend.material.color;
            if (duration <= 0.0f)
            {
                growdir = 1.0f;
            }
            else if (duration >= 1.0f)
            {
                growdir = -1.0f;
            }
            duration += growdir * 0.1f;
            mat.color = Color.Lerp(origincolor, changeColor, duration);

            yield return null;
        }
    }


    void Fade()
    {
        Color c = rend.material.color;

        if (duration <= 0.0f)
        {
            growdir = 1.0f;
        }
        else if (duration >= 1.0f)
        {
            growdir = -1.0f;
        }
        duration += growdir * 0.01f;
        mat.color = Color.Lerp(origincolor, changeColor, duration);
    }

}
