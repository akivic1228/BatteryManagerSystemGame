using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeStatus : MonoBehaviour
{
    public TextMeshProUGUI timetxt;
    public GameObject pause_panel;
    public static float playtime = 0;


    public static bool init = true;
    public static float bias_start = 0;

    int onlyone = 0;
    float s1,s2 = 0;
    float bias_pause = 0;

    private void Start()
    {
        if (init)
        {
            bias_start = Time.realtimeSinceStartup;
            init = false;
        }

    }


    void Update()
    {
        playtime = Time.realtimeSinceStartup - bias_pause - bias_start;

        if (pause_panel.activeSelf)
        {
            if (onlyone == 0)
            {
                s1 = Time.realtimeSinceStartup;
                onlyone = 1;
            }
            //暂停过程中
            if (onlyone == 1)
            {
                playtime = s1 - bias_start - bias_pause;
            }
        }
        //暂停结束
        if (!pause_panel.activeSelf && onlyone == 1)
        {
            s2 = Time.realtimeSinceStartup;
            onlyone = 0;
            bias_pause += s2 - s1;
        }
        
        timetxt.text = ((int)playtime).ToString();

    }
}
