using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_3 : MonoBehaviour
{
    GameObject play;

    void Awake()
    {
        if (ChangeScene.Charging)
            LowmodeStatus.low_mode = false;
        play = GameObject.Find("play_cat");
        if (!CatGame.isGaming)
            play.SetActive(false);
    }
}
