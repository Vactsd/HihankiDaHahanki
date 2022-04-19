using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGController : MonoBehaviour
{


    [SerializeField] private float speed = 5.75f;
    Vector3 vec3_pos;
    Vector3 oldvec3_pos;
    [SerializeField] private float MoveX =0.0f;
    [SerializeField] private float MoveY =0.0f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField]   private SpriteRenderer sprite;
    static public bool CanMove=true;
   



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();   
    }
    void RunHor()
    {
        oldvec3_pos=transform.position;
        Vector3 movement = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + movement, speed * Time.deltaTime);
        sprite.flipX = movement.x > 0.0f;
    }

     void RunVert()
    {
        oldvec3_pos=transform.position;
        Vector3 movement = transform.up * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + movement, speed * Time.deltaTime);
     // sprite.flipX = movement.x > 0.0f;
    }


    void CheckKeys()
    {
        if(CanMove)
        {
            if (Input.GetButton("Horizontal"))
            {
                RunHor();
            }
            if (Input.GetButton("Vertical") )
            {
                RunVert();
            }  
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
         
        CheckKeys();
    }



}
