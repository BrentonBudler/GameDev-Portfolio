using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickering : MonoBehaviour
{
    private float alpha;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time>0.4)
        {
            alpha = Random.Range(0f, 0.3f);
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha);
        }
        if (time>0.45)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            
        }
        if (time > 0.8)
        {
            alpha = Random.Range(0f, 0.3f);
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha);
        }
        if (time > 0.88)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            time = 0;
        }


    }
}
