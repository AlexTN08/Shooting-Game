using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxDestroied : MonoBehaviour
{
    public Text Boxes;
    private int box = 0;

    private void Start()
    {
        Boxes = GetComponent<Text>();
        Boxes.text = "Box Destroyed : " + box.ToString();
    }
    public void CountBox()
    {
        box++;
        Boxes.text = "Box Destroyed : " + box.ToString();
    }
}
