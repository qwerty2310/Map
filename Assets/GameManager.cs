using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int c;
    public Text text;
    public void Start()
    {
        c = 0;
    }
    public void ButClick()
    {
        c++;
        if (c % 2 == 0)
        {
            text.text = "";
        }
        else
        {
            text.text = "Киев (Сентябрь 1941)";
        }
    }
}
