using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupStatus : MonoBehaviour
{
    public static bool auto_off_pop = false;

    public void auto_close() { auto_off_pop = true; }
    public void not_auto_close() { auto_off_pop = false; }
}
