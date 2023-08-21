using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ChangeValue : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Slider slider;
 

    public void Change()
    {

        text.text = slider.value.ToString();
        //Debug.Log(slider.value);
        
    }

    public void shuffle()
    {
        int num = Random.Range(1, 100);
        GameObject battery = GameObject.Find("battery_Value");
        battery.GetComponent<TextMeshProUGUI>().text = num.ToString();
        GameObject batteryslider = GameObject.Find("Slider_Battary");
        batteryslider.GetComponent<Slider>().value = num;

        color_red(num);
        BatteryStatus.battery_num = num;

    }

    public void setforbattery()
    {
        text.text = slider.value.ToString();
        GameObject battery = GameObject.Find("battery_Value");
        battery.GetComponent<TextMeshProUGUI>().text = slider.value.ToString();
        GameObject batteryslider = GameObject.Find("Slider_Battary");
        batteryslider.GetComponent<Slider>().value = slider.value;

        color_red((int)slider.value);
        BatteryStatus.battery_num = (int)slider.value;
    }

    public void setlownum()
    {

        text.text = slider.value.ToString();
        LowmodeStatus.low_num = (int)slider.value;
        //Debug.Log(LowmodeStatus.low_num);


    }

    void color_red(int value)
    {

        GameObject fill = GameObject.Find("battery_fill");
        if(value <= 20)
        {
            fill.GetComponent<Image>().color = new Color(1,0,0);
        }
        else
        {
            fill.GetComponent<Image>().color = new Color(0,1,0);
        }

    }

}
