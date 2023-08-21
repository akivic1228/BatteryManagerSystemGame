using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    public Animator ani;
    public GameObject sl;
    
    public void Start()
    {
        if (sl.activeSelf) {ani.SetTrigger("t"); }
        
    }

}
