using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Painting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PicPanel;
    static public bool starttext=false;
    static public bool InPaint=false;
    static public bool StartDialog=false;
    static public bool Endtext=false;
    

    void Start()
    {
        PicPanel.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if( InPaint && Input.GetKeyDown(KeyCode.E))
        {
            PicPanel.SetActive(true);

        }
        if(!InPaint)
        {
            PicPanel.SetActive(false);
        }
        if(InPaint && Input.GetKeyDown(KeyCode.Escape))
        {
            PicPanel.SetActive(false);
            starttext=true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
            InPaint=true;
        //    GGController.CanMove=false;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag=="Nps")
        {
            InPaint=false;
          // GGController.CanMove=true;
           //Dialog.panelDialog.SetActive(false);

        }
    }


}
