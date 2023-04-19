using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float VBola;
    public Rigidbody2D oRigibody2D;

    // Start is called before the first frame update
    void Start()
    {
        oRigibody2D.velocity = new Vector2(VBola, VBola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
