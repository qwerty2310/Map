using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager8 : MonoBehaviour
{
    public int c8;
    public Text text8;
    public void Start()
    {
        c8 = 0;
    }
    public void ButClick()
    {
        c8++;
        if (c8 % 2 == 0)
        {
            text8.text = "";
        }
        else
        {
            text8.text = " раков (январь 1945)";
        }
    }
}
