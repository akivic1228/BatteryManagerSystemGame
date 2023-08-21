using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatteryCharging : MonoBehaviour
{
    public GameObject batterytext;
    public GameObject batteryslider;
    public GameObject batteryfill;

    public void Update()
    {
        batterytext.GetComponent<TextMeshProUGUI>().text = ((int)BatteryStatus.battery_num).ToString();
        batteryslider.GetComponent<Slider>().value = BatteryStatus.battery_num;
        color_red(BatteryStatus.battery_num);

        chargingChange();

        //if (battery_num <= 100 ) { chargingChange();}
        if (BatteryStatus.battery_num > 100) { 
            batterytext.GetComponent<TextMeshProUGUI>().text = "100";
            batteryslider.GetComponent<Slider>().value = 100;
        }
        // 在后台仍然充电，大于100，但是显示仍然为100（符合现实逻辑）

    }

    void chargingChange()
    {
        Time.timeScale = DeviceStatus.choice;
        //Time.timeScale = 10;
        float time = Time.deltaTime;

        BatteryStatus.battery_num += time * (float)0.8;

    }

    void color_red(float value)
    {

        GameObject fill = GameObject.Find("battery_fill");
        if (value <= 20)
            fill.GetComponent<Image>().color = new Color(1, 0, 0);
        else
            fill.GetComponent<Image>().color = new Color(0, 1, 0);
    }

}
