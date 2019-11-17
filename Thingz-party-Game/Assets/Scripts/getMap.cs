using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMap : MonoBehaviour
{

    public GameObject barrios;
    public GameObject desierto;
    public GameObject selva;
   // public GameObject my;

    public int sel;
    //PlayerSelection ps;
    void Start()
    {
       sel =  mapSelection.estado;
       Debug.Log(sel);
    }

    // Update is called once per frame
    void Update()
    {
        

        switch(sel){
            case 0:
            desierto.SetActive(true);     
            barrios.SetActive(false);
            selva.SetActive(false);
            break;
            case 1:
            barrios.SetActive(false);     
            selva.SetActive(true);
            desierto.SetActive(false);
            break;
            case 2:
            selva.SetActive(false);     
            desierto.SetActive(false);
            barrios.SetActive(true);
            break;
        }


        /* if(sel == 0){
            fs.SetActive(true);     
            gio.SetActive(false);
            touts.SetActive(false);
        }else if(sel == 1){
            gio.SetActive(true);
            fs.SetActive(false); 
            touts.SetActive(false);
        }else if(sel == 2){
            touts.SetActive(true);
            fs.SetActive(false);
            touts.SetActive(false);
        }
        */
      
    }
}
