using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject Done;
    public static NewBehaviourScript instance;

    void Start()
    {
        Done.gameObject.SetActive(false);
    }

    public void ShowRestart()
    {
        Done.gameObject.SetActive(true);
    }
}
