using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Button btnClick;

    public InputField inputUser;

    

    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }


    public void GetInputOnClickHandler()
    {
        Debug.Log("Log input: " + inputUser.text);
    }

    
}
