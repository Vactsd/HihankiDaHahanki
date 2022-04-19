using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialog : MonoBehaviour 
{

    public GameObject panelDialog;
    public Text dialog;
    public string[] message;
    [SerializeField] private int kolvo=3;
    int nowmessage=0;
    // Start is called before the first frame update
    void Start()
    {
        
        dialog = GetComponentInChildren<Text>();
        message[0]="Hello";
        message[1]="How are you";
        message[2]="good buy";
    }

    // Update is called once per frame
    void Update()
    {

        if(!GGController.CanMove)
        {
            panelDialog.SetActive(true);
            dialog.text = message[nowmessage];
            if(nowmessage==kolvo-1)
            {
                nowmessage=0;
            }
            if( Input.GetKeyDown(KeyCode.R) )
            {
                nowmessage++;
            }

        }
        if(GGController.CanMove)   
        {
            panelDialog.SetActive(false);
        }


    }
}
