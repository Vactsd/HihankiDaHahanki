using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Griaz : MonoBehaviour
{
    static public bool Startgriaz=false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
            if(TextManager.startMyMind2)
            {
              //  TextPanel.SetActive(true);
                Startgriaz=true;

            }
        }
    }
    



}
