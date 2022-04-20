using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uborshica : MonoBehaviour
{
    // Start is called before the first frame update
    static public bool Uborshica=false;


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
          Uborshica=true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
          Uborshica=false;
        }
    }


}
