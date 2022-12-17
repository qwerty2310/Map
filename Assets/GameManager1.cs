using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    public int c1;
    public Text text1;
    public void Start()
    {
        c1 = 0;
    }
    public void ButClick()
    {
        c1++;
        if (c1 % 2 == 0)
        {
            text1.text = "";
        }
        else
        {
            text1.text = "Харьков (1942)";
        }
    }
}
