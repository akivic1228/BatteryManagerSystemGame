using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreStatus : MonoBehaviour
{
    public static int score = 5;

    public Slider scoreroll;

    private void Start()
    {
        scoreroll.value = score;
    }

}
