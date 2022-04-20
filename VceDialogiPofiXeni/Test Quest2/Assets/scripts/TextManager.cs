using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class TextManager : MonoBehaviour
{
  
    static public string MyMind1 ="Хм,с этой картиной что- то странное, попробую ка я отвлечь всех от этой комнаты и посмотрю что за ней\0";
    static public string MyMind2 ="Думаю, разлив газировку в этой комнте, можно отвлечь уборщицу" ;
    static public string TalkWithCleaner = "ГГ: Доброе утро, какой-то хулиган разлил газировку в той комнате Уборщица:Щоб он сдох";
    static public string TalkWithCleaner2 = "Уборщица:Щоб он сдох";

    static public string MyMind3 ="Ох ебать как же будет логично и не странно если я полезу в потайную дверь посреди музея" ;
   
    static public bool startMyMind2=false;
    static public bool startTalkWithCleaner=false;
    static public bool startCleanerAnswer=false;
    static public bool startTalkWithWomen=false;
    static public bool startWomenAnswer=false;
    static public bool startMyMind3=false;
    static public bool DeleteDver=false;
    static public bool ExitPaint=false;
    static public bool Exit1Level=false;




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
            Replica.text="";
            PicPanel.SetActive(false);
        }

        void fs()
        {
            Replica.text="";
            Replica.text=TalkWithCleaner2;
        }

    void Loadin()
    {
        SceneManager.LoadScene("2");
    }


    void Update()
    {
        if(Painting.starttext && !ExitPaint)
        {
            TextPanel.SetActive(true);
            Replica.text=MyMind1;
            Invoke("Deleting", 5);
            Painting.starttext=false;
            startMyMind2=true;
            ExitPaint=true;
        }
        if(Griaz.Startgriaz && !Exit1Level)
        {
            TextPanel.SetActive(true);
            Replica.text=MyMind2;
            Invoke("Deleting", 5);
            f();
            Griaz.Startgriaz=false;
            canPress=true;
        }
        if(canPress && Input.GetKeyDown(KeyCode.E)&& !Exit1Level)
        {
            Spot.transform.position= new Vector3 (GGController.x, GGController.y, GGController.z) ;
            Spot.transform.position+= new Vector3 (0,0, -10) ;
            canPress=false;
            startTalkWithCleaner=true;
            Invoke("fd", 1.0f);
            Exit1Level=true;
        }

        if(startTalkWithCleaner && uborshica.Uborshica && Input.GetKeyDown(KeyCode.E) )
        {
            startTalkWithCleaner=false;
            Replica.text=TalkWithCleaner;
            //Invoke("fs", 4.0f);
            Invoke("Deleting", 5);
            TextPanel.SetActive(true);
            startMyMind3=true;
        }
        if( startMyMind3 && Dver1.Dver && Input.GetKeyDown(KeyCode.E))
        {
            DeleteDver=true;
            startMyMind3=false;
            Replica.text=MyMind3;
            TextPanel.SetActive(true);
            Invoke("Deleting", 5);
            Invoke("Loadin", 2.0f);
        }


    }
}
