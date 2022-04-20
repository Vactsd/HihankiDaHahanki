using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door23 :  MonoBehaviour
{
 //   public GGController gg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
            GGController.vec3_pos=new Vector3(-14.54f,-190.22f,6.1f);
            GGController.ChangedPosition=true;

        }   
    }

}
