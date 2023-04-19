using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
    //criando variáveis
    public float VJogador;
    public bool J1;

    public float yMinimo;
    public float yMaximo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(J1 == true)
        {
            MovJ1();
        }
        if (J1 == false)
        {
            MovJ2();
        }
    }

    //criando métodos próprios
    public void MovJ1()

    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo)); 

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * VJogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * VJogador * Time.deltaTime);
        }
    }

    public void MovJ2()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * VJogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * VJogador * Time.deltaTime);
        }
    }
}
