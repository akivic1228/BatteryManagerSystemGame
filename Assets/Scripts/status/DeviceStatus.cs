using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeviceStatus : MonoBehaviour
{
    public static int choice = 0;

    public GameObject error;

    public void cable()
    {
        choice = 3;
        //Debug.Log(choice);
    }

    public void portable()
    {
        choice = 2;
        //Debug.Log(choice);
    }

    public void wireless()
    {
        choice = 1;
        //Debug.Log(choice);
    }

    public void if_no_choice()
    {
        if (choice != 0)
            SceneManager.LoadScene("Start_2");
        else
            error.SetActive(true);
    }
}
