using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public GameObject player;
    private Vector3 _mousePos;
    private Vector2 _direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _direction = new Vector2(_mousePos.x - transform.position.x, _mousePos.y - transform.position.y);
        transform.up = _direction;
    }
}
