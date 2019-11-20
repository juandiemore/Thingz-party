using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCharacter2 : MonoBehaviour
{

    public GameObject fs;
    public GameObject gio;
    public GameObject touts;
   // public GameObject my;

    public int sel;
    //PlayerSelection ps;
    void Start()
    {
       sel =  PlayerSelection2.seleccion;
       Debug.Log(sel);
    }

    // Update is called once per frame
    void Update()
    {
        

        switch(sel){
            case 1:
            fs.SetActive(true);     
            gio.SetActive(false);
            touts.SetActive(false);
            break;
            case 2:
            fs.SetActive(false);     
            gio.SetActive(true);
            touts.SetActive(false);
            break;
            case 3:
            fs.SetActive(false);     
            gio.SetActive(false);
            touts.SetActive(true);
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
