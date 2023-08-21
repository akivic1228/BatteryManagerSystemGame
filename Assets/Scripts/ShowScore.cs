using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{

    public TextMeshProUGUI text_info;
    public TextMeshProUGUI text_logs;

    // Update is called once per frame
    void Start()
    {
        text_info.text = "Your score is:" + ScoreStatus.score.ToString();
        text_logs.text = "";
        show();

    }

    void show()
    {
        for (int i = 1;i < 8; i++)
        {
            if (ScoreChange.onlyones[i] == 1)
            {
                switch (i)
                {
                    case 1:
                        text_logs.text += "\n ，Does not stop charging after a pop-up reminder, -1";
                        break;
                    case 2:
                        text_logs.text += "\n ，Play your phone while charging, -2";
                        break;
                    case 3:
                        text_logs.text += "\n ，No charging when the level falls below 10%, -1";
                        break;
                    case 4:
                        text_logs.text += "\n ，No low battery mode on, -1";
                        break;
                    case 5:
                        text_logs.text += "\n ，Locking screen during charging, +1";
                        break;
                    case 6:
                        text_logs.text += "\n ，Sleep during charging, +1";
                        break;
                    case 7:
                        text_logs.text += "\n ，Low battery mode on as required, +1";
                        break;
                }
            }
        }
    }
}
