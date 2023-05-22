using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D controller;
    public static PlayerMovment instance;

    Rigidbody2D body;

    [SerializeField] GameObject Done;

    public InputField iField;
    string myName;
    string playMoveDir;
    string playMoveNumb;
    public string[] lines;

    float x = -9f;
    float y = -4f;
    float z = 0f;
    Vector3 pos;

    public float speed = 10f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private IEnumerator PlayerMoveWait()
    {
        lines = iField.text.Split('\n');

        foreach (string txtt in lines)
        {

            string inputString = txtt;

            string pattern = @"\d+";

            Match match = Regex.Match(inputString, pattern);

            if (match.Success)
            {
                playMoveNumb = match.Value;
            }
            else
            {
                Debug.Log("Error");
            }



            string myString = inputString.ToLower();
            char delimiter = ' ';
            string[] possibleWords = { "right", "left", "up", "down" };

            string[] words = myString.Split(delimiter);
            foreach (string word in words)
            {
                if (Array.IndexOf(possibleWords, word) >= 0)
                {
                    playMoveDir = word;
                    break;
                }

            }


            float playMoveNum = (float.Parse(playMoveNumb) / 5);

            Debug.Log(playMoveDir);
            Debug.Log(playMoveNumb);
            Debug.Log(playMoveNum);

            if (playMoveDir == "right")
            {
                body.velocity = new Vector2(1, 0);
                Debug.Log("10 right");
                iField.text = "";
                Invoke("StopMove", playMoveNum);
            }
            else if (playMoveDir == "left")
            {
                body.velocity = new Vector2(-1, 0);
                Debug.Log("10 Left");
                iField.text = "";
                Invoke("StopMove", playMoveNum);
            }
            else if (playMoveDir == "up")
            {
                body.velocity = new Vector2(0, 1);
                Debug.Log("10 Up");
                iField.text = "";
                Invoke("StopMove", playMoveNum);
            }
            else if (playMoveDir == "down")
            {
                body.velocity = new Vector2(0, -1);
                Debug.Log("10 Down");
                iField.text = "";
                Invoke("StopMove", playMoveNum);
            }
            WaitForSeconds wait = new WaitForSeconds(playMoveNum);
            yield return wait;

        }
        Done.gameObject.SetActive(true);
    }

    public void MyFunction()
    {
        StartCoroutine(PlayerMoveWait());
    } 

    void StopMove()
    {
        body.velocity = new Vector2(0, 0);
    }

    public void Restart()
    {
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
