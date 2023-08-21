using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        //预处理
        #if UNITY_EDITOR    //在编辑器模式下
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            #if UNITY_EDITOR    //在编辑器模式下
            EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }

}



