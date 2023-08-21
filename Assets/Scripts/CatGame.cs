using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatGame : MonoBehaviour
{
    [HideInInspector]
    public static int num;
    public GameObject[] cats_shadow;
    public GameObject[] cats_show;


    public Button btn_start;
    public Button btn_stop;

    // �Ƿ���ֹͣ�齱״̬(Ĭ����ֹͣ״̬)
    public static bool isStop;
    // ��Ϸ״̬��¼
    public static bool isGaming;
    public static int play_scene;

    private void Start()
    {
        //cats_show = GameObject.FindGameObjectsWithTag("cat_show");
        //cats_shadow = GameObject.FindGameObjectsWithTag("cat_shadow");
        for (int i = 0; i < cats_shadow.Length; i++)
            cats_show[i].SetActive(false);
        for (int i = 0; i < cats_shadow.Length; i++)
            cats_shadow[i].SetActive(false);
        if (isGaming)
            sceneChangeRestore();
        else
            init();
    }


    private void init()
    {
        isGaming = true;
        isStop = true;
        num = 0;
        cats_shadow[0].SetActive(true);
        for (int i = 1; i < 5; i++)
            cats_shadow[i].SetActive(false);
        play_scene = 1;
    }
    
    public void start_shuffle()
    {
        // ������ڳ齱
        if (isStop)
        {
            for (int i = 0; i <= 4; i++)
            {
                cats_show[i].SetActive(false);
            }
            cats_shadow[0].SetActive(false);
            // ����Э��
            StartCoroutine("LuckDraw");
            // �ı�齱״̬
            isStop = false;
            play_scene = 2;
        }
    }

    public void stop_shuffle()
    {
        if (!isStop)
        {
            StopCoroutine("LuckDraw");
            cats_shadow[num].SetActive(false);
            isStop = true;
            resultShow();
        }
    }

    // �齱Э��
    private IEnumerator LuckDraw()
    {

        while (true)
        {
            num = Random.Range(0, 5);
            cats_shadow[num].SetActive(true);
            for (int i = 0; i < 5; i++)
            {
                if (i != num)
                    cats_shadow[i].SetActive(false);
            }

            yield return null;
        }
    }

    private void resultShow()
    {
        cats_show[num].SetActive(true);
        play_scene = 3;
    }

    //�����л���ص���һ������״̬
    private void sceneChangeRestore()
    {
        if (play_scene == 2)
        {
            StartCoroutine("LuckDraw");
        }
        else
        {
            if (play_scene == 1)
                init();
            if (play_scene == 3)
                cats_show[num].SetActive(true);
        }
    }
    public void closeGame()
    {
        isGaming = false;
    }
}


