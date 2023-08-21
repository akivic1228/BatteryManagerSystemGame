using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    GameObject[] popups;
    public GameObject play;
    public GameObject sleep;
    public GameObject black;

    public Slider scoreroll;

    public static int[] onlyones = { 0, 0, 0, 0, 0, 0, 0, 0 };//仅调用一次
    int status = 0;

    private void Start()
    {
        popups = GameObject.FindGameObjectsWithTag("popup");
        //play = GameObject.Find("playing");
        //sleep = GameObject.Find("sleeping");
        //for (int i = 0; i < 8; i++)
        //{
        //    onlyones[i] = 0;
        //}
    }



    void Update()
    {
        down();
        up();
        scoreroll.value = ScoreStatus.score;
    }


    void down()
    {
        if (ChangeScene.Charging)//充电中
        {
            //弹窗后不拔插头(弹窗消失前)
            if (PopupChange.fclose)
            {
                status = 1;
                PopupChange.fclose = false;
            }
            //充电时玩手机
            if (play.activeSelf)
                status = 2;
        }

        if (!ChangeScene.Charging)
        {
            //在红色电量时不充电
            if ((int)BatteryStatus.battery_num <= 10)
                status = 3;
            //不开启低电量模式(不自动开、选no则减分）
            if (!LowmodeStatus.auto_mode && LowmodeStatus.fno)
            {
                status = 4;
                LowmodeStatus.fno = false;
            }
        }

        if (onlyones[status] == 0)
        {
            Debug.Log("status:" + status);
            onlyones[status] = 1;
            switch (status)
            {
                case 0:
                    break;
                case 1:
                    ScoreStatus.score -= 1;
                    Debug.Log("1:-" + 1);
                    break;
                case 2:
                    ScoreStatus.score -= 2;
                    break;
                case 3:
                    ScoreStatus.score -= 1;
                    break;
                case 4:
                    ScoreStatus.score -= 1;
                    break;
            }
            Debug.Log("score:" + ScoreStatus.score);
        }
    }

    void up()
    {

        if (ChangeScene.Charging)
        {
            //充电过程中锁屏
            if (black.activeSelf)
                status = 5;
            //充电过程中休眠
            if (sleep.activeSelf)
                status = 6;
        }

        if (!ChangeScene.Charging)
        {
            //按规定开启低电量模式(自动开、主动开）
            if (LowmodeStatus.auto_mode || LowmodeStatus.fyes)
            {
                status = 7;
                LowmodeStatus.fyes = false;
            }
        }


        if (onlyones[status] == 0)
        {
            Debug.Log("status:" + status);
            onlyones[status] = 1;
            switch (status)
            {
                case 0:
                    break;
                case 5:
                    ScoreStatus.score += 1;
                    break;
                case 6:
                    ScoreStatus.score += 1;
                    break;
                case 7:
                    ScoreStatus.score += 1;
                    break;
            }
            Debug.Log("score:" + ScoreStatus.score);

        }
    }
}
