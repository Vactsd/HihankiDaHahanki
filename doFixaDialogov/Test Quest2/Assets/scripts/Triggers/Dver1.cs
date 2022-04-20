using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dver1 : MonoBehaviour
{


    public GameObject Paint;

    static public bool Dver=false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
          Dver=true;
        }

    }



    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
          Dver=false;
        }
    }

private void FixedUpdate() {
    if(TextManager.DeleteDver)
    {
        Paint.transform.position=new Vector3(0,11111,99999);
    }
}



}
