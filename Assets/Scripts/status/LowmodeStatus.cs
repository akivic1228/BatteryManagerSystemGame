using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowmodeStatus : MonoBehaviour
{
    public static bool auto_mode = false; //Ĭ�Ϲرյ͵���ģʽ
    public static int low_num = 20; //�͵���ģʽĬ��ֵΪ20
    public static bool low_mode = false;
    public static bool fno = false;
    public static bool fyes = false;


    public void auto_on() { auto_mode = true; }
    public void auto_off() { auto_mode = false; }

}
