using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controler : MonoBehaviour
{

    private Animator ini;
    // Start is called before the first frame update
    void Start()
    {
          ini = GetComponent<Animator>();
    }

    // Update is called once per frame
 IEnumerable transicion(){
     yield return new WaitForSeconds(1.5f);
     SceneManager.LoadScene("juego");
 }

}
