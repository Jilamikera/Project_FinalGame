using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrenctPickup : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
     void Update()
    {
        coinText.text =": " +coinCount.ToString();
    }
}
