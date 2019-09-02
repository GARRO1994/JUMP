using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtColor : MonoBehaviour
{
    private Text txt;
    private Outline oline;

    void Start()
    {
        txt = GetComponent<Text>();
        oline = GetComponent<Outline>();
    }

    void Update()
    {
        txt.color = new Color(txt.color.g, txt.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        oline.effectColor = new Color(oline.effectColor.r, oline.effectColor.g, oline.effectColor.b, txt.color.a);

    }
}
