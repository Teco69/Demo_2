using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarDeTela : MonoBehaviour
{
    public string cena;

   void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(cena);
        }




   }
}
