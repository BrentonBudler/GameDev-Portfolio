using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public GameObject mummySprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Player") {
            Destroy(mummySprite);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
