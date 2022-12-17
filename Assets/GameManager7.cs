using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager7 : MonoBehaviour
{
    public int c7;
    public Text text7;
    public void Start()
    {
        c7 = 0;
    }
    public void ButClick()
    {
        c7++;
        if (c7 % 2 == 0)
        {
            text7.text = "";
        }
        else
        {
            text7.text = "ֻüגמג (ָ‏כü 1944)";
        }
    }
}
