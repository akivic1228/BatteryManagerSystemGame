using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    GameObject end_btn;
    private void Start()
    {
        end_btn = GameObject.FindGameObjectWithTag("endgame");
        end_btn.SetActive(false);
    }

    void Update()
    {
        if ((int)TimeStatus.playtime >= 60)
        {
            end_btn.SetActive(true);
        }
        if ((int)TimeStatus.playtime == 120)
            SceneManager.LoadScene("End");
        if (BatteryStatus.battery_num < -30)
            SceneManager.LoadScene("End");
    }

    public void end_for_score()
    {
        SceneManager.LoadScene("End");
    }
}
