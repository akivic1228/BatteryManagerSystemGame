using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatteryLeaking : MonoBehaviour
{
    public GameObject batterytext;
    public GameObject batteryslider;
    public GameObject batteryfill;

    public GameObject shut_down;

    public void Update()
    {
        batterytext.GetComponent<TextMeshProUGUI>().text = ((int)BatteryStatus.battery_num).ToString();
        batteryslider.GetComponent<Slider>().value = BatteryStatus.battery_num;
        color_red(BatteryStatus.battery_num);

        //if (battery_num <= 100 ) { chargingChange();}
        if (BatteryStatus.battery_num > 100)
        {
            batterytext.GetComponent<TextMeshProUGUI>().text = "100";
            batteryslider.GetComponent<Slider>().value = 100;
            BatteryStatus.battery_num = 100;
        }

        leakingChange();

        if (BatteryStatus.battery_num < 1)
        {
            BatteryStatus.battery_num = 0;
            shut_down.SetActive(true);
        }

    }

    void leakingChange()
    {
        Time.timeScale = DeviceStatus.choice;
        //Time.timeScale = 10;
        float time = Time.deltaTime;

        BatteryStatus.battery_num -= time * (float)1.2;
    }

    void color_red(float value)
    {

        GameObject fill = GameObject.Find("battery_fill");
        if (LowmodeStatus.low_mode)
            fill.GetComponent<Image>().color = new Color(1, 1, 0);
        else
        {
            if (value <= 20)
                fill.GetComponent<Image>().color = new Color(1, 0, 0);
            else
                fill.GetComponent<Image>().color = new Color(0, 1, 0);
        }
    }
}
