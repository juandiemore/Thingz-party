using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{   
    private Animator ini;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {
        ini = GetComponent<Animator>();
        inicio = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.anyKey)
        {
            ini.SetBool("logo",true);
        }
      
    }
    public void LoadMenu(){
     //   this.SetActive(false);
        
    }
}
