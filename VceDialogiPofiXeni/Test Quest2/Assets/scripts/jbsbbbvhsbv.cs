using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jbsbbbvhsbv : MonoBehaviour
{
    public GameObject panelDialog;
    public GameObject panelDialog2;

    // Start is called before the first frame update
    void Start()
    {
        panelDialog.SetActive(false);
        panelDialog2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
          if( Input.GetKeyDown(KeyCode.Q))
          {
            panelDialog2.SetActive(true);
          }
    }
}
