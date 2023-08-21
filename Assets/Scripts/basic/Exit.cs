using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        //Ԥ����
        #if UNITY_EDITOR    //�ڱ༭��ģʽ��
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            #if UNITY_EDITOR    //�ڱ༭��ģʽ��
            EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }

}



