using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject textBox;

    public void Click()
    {
        textBox.SetActive(true);
    }
}
