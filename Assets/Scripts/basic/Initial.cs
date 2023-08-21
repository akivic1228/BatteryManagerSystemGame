using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //把所有的全局变量初始化
        BatteryStatus.battery_num = 0;
        LowmodeStatus.low_num = 20;
        DeviceStatus.choice = 0;
        LowmodeStatus.auto_mode = false;
        LowmodeStatus.low_num = 20;
        LowmodeStatus.low_mode = false;
        LowmodeStatus.fno = false;
        LowmodeStatus.fyes = false;
        PopupStatus.auto_off_pop = false;
        TimeStatus.bias_start = 0;
        TimeStatus.init = true;
        ScoreStatus.score = 5;
        ChangeScene.Charging = true;
        CatGame.isGaming = false;
        for (int i = 0; i < 8; i++)
            ScoreChange.onlyones[i] = 0;


    }

}
