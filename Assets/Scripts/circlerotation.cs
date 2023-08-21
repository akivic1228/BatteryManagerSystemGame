using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class circlerotation : MonoBehaviour
{
    //[SerializeField] RectTransform FxHolder;
    [SerializeField] Image CircleImg;
    [SerializeField] GameObject txtProgress0;
    [SerializeField] GameObject txtProgress100;

    [SerializeField][Range(0, 1)] float progress = 0f;

    public static float time_for_charging;

    void Start()
    {
        txtProgress0.SetActive(true);
        txtProgress100.SetActive(false);
        time_for_charging = 0;

    }


    void Update()
    {
        //float time = Mathf.Floor(progress * 60);
        //Time.timeScale = 10;
        //Time.timeScale = DeviceStatus.choice;
        //float time = Mathf.Floor(Time.timeSinceLevelLoad);

        time_for_charging += Time.fixedDeltaTime;
        progress = time_for_charging / 60;

        Text txt0 = txtProgress0.GetComponent<Text>();
        Text txt100 = txtProgress100.GetComponent<Text>();

        if (time_for_charging < 10)
        {
            CircleImg.fillAmount = progress;
            txt0.text = "0" + time_for_charging.ToString();
            //Debug.Log(txtProgress.text);
            CircleImg.color = new Color((float)0.282353, (float)0.6745098, (float)0.8862746);

        }

        if (time_for_charging < 45 && time_for_charging >= 10)
        {
            CircleImg.fillAmount = progress;
            txt0.text = time_for_charging.ToString();
            CircleImg.color = new Color((float)0.282353, (float)0.6745098, (float)0.8862746);
        }

        if (time_for_charging >= 45 && time_for_charging < 60)
        {
            CircleImg.fillAmount = progress;
            txt0.text = time_for_charging.ToString();
            CircleImg.color = new Color((float)0.8862745, (float)0.7048205, (float)0.282353);
        }

        if (time_for_charging >= 60 && time_for_charging < 100)
        {
            CircleImg.fillAmount = 1;
            CircleImg.color = new Color((float)0.8862745, (float)0.2979927, (float)0.282353);
            txt0.text = time_for_charging.ToString();

        }

        if (time_for_charging >= 100)
        {
            CircleImg.fillAmount = 1;
            CircleImg.color = new Color((float)0.8862745, (float)0.2979927, (float)0.282353);
            txtProgress0.SetActive(false);
            txtProgress100.SetActive(true);
            txt100.text = time_for_charging.ToString();
            
        }
    }
}
