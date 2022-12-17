using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager9 : MonoBehaviour
{
    public int c9;
    public Text text9;
    public void Start()
    {
        c9 = 0;
    }
    public void ButClick()
    {
        c9++;
        if (c9 % 2 == 0)
        {
            text9.text = "";
        }
        else
        {
            text9.text = "Пригороды Праги (Май 1945)";
        }
    }
}
