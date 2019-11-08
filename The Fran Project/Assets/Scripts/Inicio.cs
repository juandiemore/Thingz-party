using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{   
    private Animator ini;



    // Start is called before the first frame update
    void Start()
    {
        ini = GetComponent<Animator>();
       

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
        SceneManager.LoadScene("menu");
   
    }
}
