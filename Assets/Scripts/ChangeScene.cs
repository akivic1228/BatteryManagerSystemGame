using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public static bool Charging = true;
    public void ChangeScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        if (sceneName == "Start_2")
            Charging = true;
        if (sceneName == "Start_3")
            Charging = false;
    }

}


