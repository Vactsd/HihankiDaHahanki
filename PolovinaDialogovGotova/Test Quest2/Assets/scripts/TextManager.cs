using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
  
    static public string MyMind1 ="Хм,с этой картиной что- то странное, попробую ка я отвлечь всех от этой комнаты и посмотрю что за ней\0";
    static public string MyMind2 ="Думаю, разлив газировку в этой комнте, можно отвлечь уборщицу" ;

    static public string TalkWithCleaner = "Доброе утро, какой-то хулиган разлил газировку в той комнате";
    static public string CleanerAnswer="Щоб он сдох";
    static public string MyMind3 ="Ох ебать как же будет логично и не странно если я полезу в потайную дверь посреди музея" ;
   
    static public bool startMyMind2=false;
    static public bool startTalkWithCleaner=false;
    static public bool startCleanerAnswer=false;
    static public bool startTalkWithWomen=false;
    static public bool startWomenAnswer=false;
    static public bool startMyMind3=false;



    public Text Replica;
    public GameObject TextPanel;
    public GameObject PicPanel;
    public GameObject Spot;
    
    bool canPress=false;
    void Start()
    {
        Replica.text="";
        TextPanel.SetActive(false);
        PicPanel.SetActive(false);

    }
        void Deleting()
        {
            Replica.text="";
            TextPanel.SetActive(false);
        }
        void f()
        {
            PicPanel.SetActive(true);
        }
        void fd()
        {
            PicPanel.SetActive(false);
        }
    void Update()
    {
        if(Painting.starttext)
        {
            TextPanel.SetActive(true);
            Replica.text=MyMind1;
            Invoke("Deleting", 5);
            Painting.starttext=false;
            startMyMind2=true;
        }
        if(Griaz.Startgriaz)
        {
            TextPanel.SetActive(true);
            Replica.text=MyMind2;
            Invoke("Deleting", 5);
            f();
         //   Invoke("f", 5.0f);
            Griaz.Startgriaz=false;
            canPress=true;
          //  PicPanel.SetActive(true);
        }
        if(canPress && Input.GetKeyDown(KeyCode.E))
        {
            Spot.transform.position= new Vector3 (GGController.x, GGController.y, GGController.z) ;
            Spot.transform.position+= new Vector3 (0,0, -10) ;
            canPress=false;
            Invoke("fd", 1.0f);
        }
    }
}
