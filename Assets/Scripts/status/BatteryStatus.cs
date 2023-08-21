using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatteryStatus : MonoBehaviour
{
    public static float battery_num = 0;

    void Start()
    {
        this.GetComponent<TextMeshProUGUI>().text = ((int)battery_num).ToString();
    }

}
