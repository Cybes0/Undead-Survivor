using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject[] titles;

    public void Lose()
    {
        titles[0].SetActive(true);
    }

    // Update is called once per frame
    public void Win()
    {
        titles[1].SetActive(true);
    }
}
