using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speedAtual = 12.0f;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speedAtual * entradaHorizontal);

         float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speedAtual * entradaVertical);
    }
}
