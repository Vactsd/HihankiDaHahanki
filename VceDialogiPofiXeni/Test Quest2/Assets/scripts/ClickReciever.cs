using UnityEngine;
using System;
using System.Collections;
using UnityEngine.EventSystems;

public class ClickReciever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray =Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x,Input.mousePosition.y,1));
            RaycastHit _hit;
            if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
            {
                Debug.Log("12312 313");
            }
        }
    }
}
