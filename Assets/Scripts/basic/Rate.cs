using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rate : MonoBehaviour
{
    public Button[] starButton1;
    public Button[] starButton2;
    //public Button acceptButton;
    [HideInInspector] public int ratedApp; // rate stor value can be used for something after rating
    public void rateone(int rate)
    {
        ratedApp = rate;

        //// active rate button if use click some stars
        //if (rate > 0)
        //    acceptButton.GetComponent<Button>().interactable = true;

        // enable stars equal than user rated
        for (int i = 0; i < rate; i++)
        {
            foreach (Transform t in starButton1[i].transform)
            {
                t.gameObject.SetActive(true);
            }
        }

        // enable stars greater than user rated
        for (int i = rate; i < starButton1.Length; i++)
        {
            foreach (Transform t in starButton1[i].transform)
            {
                t.gameObject.SetActive(false); 
            }

        }
    }

    public void ratetwo(int rate)
    {
        ratedApp = rate;

        //// active rate button if use click some stars
        //if (rate > 0)
        //    acceptButton.GetComponent<Button>().interactable = true;

        // enable stars equal than user rated
        for (int i = 0; i < rate; i++)
        {
            foreach (Transform t in starButton2[i].transform)
            {
                t.gameObject.SetActive(true);
            }
        }

        // enable stars greater than user rated
        for (int i = rate; i < starButton2.Length; i++)
        {
            foreach (Transform t in starButton2[i].transform)
            {
                t.gameObject.SetActive(false);
            }

        }
    }
}
