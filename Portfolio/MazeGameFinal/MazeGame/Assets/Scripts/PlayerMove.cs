using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private  Rigidbody2D rigidBody;
    public float speed = 0.05f;
    public Animator anim;
    public GameObject obj; 
 
    // Start is called before the first frame update



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="tip")
        {
            // anim.SetBool("Dying", true);
            obj.GetComponent<Paused>().LoadDead();
            // StartCoroutine(Waiting()); 
         //   this.transform.SetPositionAndRotation(new Vector3(-4f, -4.17f, 0f), Quaternion.identity);
         
        }

        if (collision.gameObject.name == "END")
        {
            Destroy(this.gameObject);
            obj.GetComponent<Paused>().LoadWon();

        }
    }

    void Start()
    {
       
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float translationY = Input.GetAxis("Vertical") * speed;
        float translationX = Input.GetAxis("Horizontal") * speed;

        rigidBody.velocity = new Vector2(translationX, translationY);


        anim.SetBool("Walking", false);
        anim.SetBool("WalkingUp", false);
        anim.SetBool("WalkingSide", false);
        this.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 1);



        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            anim.SetBool("WalkingUp", true);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("WalkingSide", true);

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("WalkingSide", true);
            this.gameObject.transform.localScale = new Vector3(-0.7f,0.7f,1); 



            }

    }

    IEnumerator Waiting()
    {
        
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("Dying", false);
        
       
    }

   
}
