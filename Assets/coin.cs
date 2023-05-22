using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int value;

    public static coin instance;

    float x;
    float y;
    float z;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        z = 0;
        x = Random.Range(-9.5f, 0.2f);

        if (x < 8)
        {
            y = Random.Range(-3.1f, 4.2f);
        }
        else
        {
            y = Random.Range(-4.1f, 4.2f);
        }
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinCounter.instance.increaseCoins(value);
        }
    }

    public void Restart()
    {
        z = 0;
        x = Random.Range(-9.5f, 0.2f);

        if (x < 8)
        {
            y = Random.Range(-3.1f, 4.2f);
        }
        else
        {
            y = Random.Range(-4.1f, 4.2f);
        }
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
