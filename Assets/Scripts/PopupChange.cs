using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class PopupChange : MonoBehaviour
{
    public GameObject p80;
    public GameObject p100;
    public GameObject t60;
    public GameObject black;
    public GameObject sleep;

    GameObject end;
    int n = 0;
    public static int duration = 10;
    public static bool fclose = false;

    public void closepopup(){ end.SetActive(false); fclose = true; }
    void suspend() { fclose = true; }

    void Update()
    {
        if (black.activeSelf || sleep.activeSelf)
            n = 0;
        else
        {
            if ((int)circlerotation.time_for_charging == 60)
                n = 1;
            if ((int)BatteryStatus.battery_num == 80)
                n = 2;
            if ((int)BatteryStatus.battery_num == 100)//ÅĞ¶ÏÌõ¼şÒª¸Ä£¬Ì«´Ö±©£¬µ¯´°²»Ë¿»¬
                n = 3;
        }

        switch(n)
        {
            case 0:
                break;
            case 1:
                t60.SetActive(true);
                p80.SetActive(false);
                p100.SetActive(false);
                if (PopupStatus.auto_off_pop) { end = t60; Invoke("closepopup", duration); }
                else { Invoke("suspend", duration);}
                n = 0;
                break;
            case 2:
                p80.SetActive(true);
                t60.SetActive(false);
                p100.SetActive(false);
                n = 0;
                if (PopupStatus.auto_off_pop) { end = p80; Invoke("closepopup", duration); }
                else { Invoke("suspend", duration);}
                break;
            case 3:
                p100.SetActive(true);
                p80.SetActive(false);
                t60.SetActive(false);
                n = 0;
                if (PopupStatus.auto_off_pop) { end = p100; Invoke("closepopup", duration);}
                else { Invoke("suspend", duration); }
                break;

        }



        //    if (Time.timeSinceLevelLoad >= 60 && BatteryStatus.battery_num < 80)
        //    {
        //        if (Time.timeSinceLevelLoad == 60)
        //        {
        //            t60.SetActive(true);
        //            p80.SetActive(false);
        //            p100.SetActive(false);
        //        }
        //        if (auto_off_pop) { end = t60; Invoke("closepopup", 5); }

        //        if (BatteryStatus.battery_num == 80)
        //        {
        //            p80.SetActive(true);
        //            t60.SetActive(false);
        //            if (auto_off_pop) { end = p80; Invoke("closepopup",5); }
        //        }
        //        if (BatteryStatus.battery_num == 100)
        //        {
        //            p80.SetActive(false);
        //            p100.SetActive(true);
        //            if (auto_off_pop) { end = p100; Invoke("closepopup", 5); }
        //        }
        //    }


        //    if (Time.timeSinceLevelLoad < 60 && BatteryStatus.battery_num == 80)
        //    {
        //        p80.SetActive(true);
        //        t60.SetActive(false);
        //        p100.SetActive(false);
        //        if (auto_off_pop) { end = p80; Invoke("closepopup", 5); }

        //        if (Time.timeSinceLevelLoad == 60 && BatteryStatus.battery_num < 100)
        //        {
        //            p80.SetActive(false);
        //            t60.SetActive(true);
        //            //if (auto_off_pop) { closepopup(t60); }

        //            if (BatteryStatus.battery_num == 100)
        //            {
        //                t60.SetActive(false);
        //                p100.SetActive(true);
        //                //if (auto_off_pop) { closepopup(p100); }
        //            }
        //        }
        //        if (Time.timeSinceLevelLoad < 60 && BatteryStatus.battery_num == 100)
        //        {
        //            p80.SetActive(false);
        //            p100.SetActive(true);
        //            //if (auto_off_pop) { closepopup(p100); }

        //            if (Time.timeSinceLevelLoad == 60)
        //            {
        //                p100.SetActive(false);
        //                t60.SetActive(true);
        //                //if (auto_off_pop) { closepopup(t60); }
        //            }
        //        }

        //    }

    }
}
