using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PicPanel2;
    public GameObject PicPanel;
    public GameObject Canvas;
    public GameObject PicPanel3;



    static public bool CanMove=true;
    static public bool InPaint=false;
    static public bool StartDialog=false;

    void Start()
    {
        PicPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( InPaint && Input.GetKeyDown(KeyCode.E))
        {
            PicPanel3.SetActive(false);
            PicPanel.SetActive(true);

        }
        if(!InPaint)
        {
            PicPanel.SetActive(false);
        }
        if(InPaint && Input.GetKeyDown(KeyCode.Escape))
        {
            PicPanel.SetActive(false);
        //    Destroy(Canvas);
            PicPanel2.SetActive(true);
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
