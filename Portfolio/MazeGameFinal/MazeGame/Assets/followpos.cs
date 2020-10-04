using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpos : MonoBehaviour
{
    public GameObject obj;
  public   Animator an;
    private Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj.transform.position;
      //  an.SetBool("WalkDown", false);
       // an.SetBool("WalkUp", false);


        if (obj.transform.rotation.eulerAngles.z > 260 && obj.transform.rotation.eulerAngles.z < 275)
        {

            an.SetBool("WalkDown", true);
        }

        if (obj.transform.rotation.eulerAngles.z > 170 && obj.transform.rotation.eulerAngles.z < 185)
        {
            an.SetBool("WalkDown", false);
            an.SetBool("WalkUp", false);
            transform.localScale = scale;
            Debug.Log("left"); 
        }

        if (obj.transform.rotation.eulerAngles.z > 345 && obj.transform.rotation.eulerAngles.z < 360|| obj.transform.rotation.eulerAngles.z >= 0 && obj.transform.rotation.eulerAngles.z < 10)
        {
            an.SetBool("WalkDown", false);
            an.SetBool("WalkUp", false);
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
            Debug.Log("right");
        }

        if (obj.transform.rotation.eulerAngles.z > 80 && obj.transform.rotation.eulerAngles.z < 95)
        {

            an.SetBool("WalkUp", true);
        }



    }
}
