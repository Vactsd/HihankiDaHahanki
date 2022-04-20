using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    static public bool InDialogArea=false;
    static public bool EndDialog=false;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
            InDialogArea=true;
            GGController.CanMove=false;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
           InDialogArea=false;     
           GGController.CanMove=true;
           //Dialog.panelDialog.SetActive(false);

        }
    }
  

}
