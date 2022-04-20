using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGController : MonoBehaviour
{


    [SerializeField] private float speed = 10.75f;
    static public Vector3 vec3_pos;
    Vector3 oldvec3_pos;
    [SerializeField] private float MoveX =0.0f;
    [SerializeField] private float MoveY =0.0f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField]   private SpriteRenderer sprite;
    static public bool CanMove=true;
    static public bool ChangedPosition=true;
    public GameObject Pleer;
    public Vector3 pos;
    static public float x=0;
    static public float y=0;
    static public float z=0;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();   
    }
    void RunHor()
    {
        Vector3 movement = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + movement, speed * Time.deltaTime);
        sprite.flipX = movement.x > 0.0f;
    }

     void RunVert()
    {
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
        z=transform.position.z;
        x=transform.position.x;
        y=transform.position.y;


       if(ChangedPosition)
       {
        transform.position = vec3_pos;
        ChangedPosition=false;
       }

        CheckKeys();
    }



}
