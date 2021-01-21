using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;

        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = theSeconds.ToString();
        timeDisplay02.GetComponent<Text>().text = theSeconds.ToString();
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
