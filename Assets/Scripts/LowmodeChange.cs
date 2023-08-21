using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowmodeChange : MonoBehaviour
{
    public GameObject turn_on_mode;

    int onlyone = 0;

    public void Update()
    {
        //只在放电过程中才会出现,给start3挂一个
        if (BatteryStatus.battery_num <= LowmodeStatus.low_num)
        {
            if (!LowmodeStatus.auto_mode && onlyone == 0)
            {
                turn_on_mode.SetActive(true);
                onlyone = 1;
            }

            if (LowmodeStatus.auto_mode)
                LowmodeStatus.low_mode = true;
        }
    }

    public void turn_on()
    {
        LowmodeStatus.low_mode = true;
        LowmodeStatus.fyes = true;
    }

    public void choose_no()
    {
        LowmodeStatus.fno = true;
    }
}
