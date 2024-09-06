using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRight : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        PlayeriYukariAsagiHareketi();
    }
    void PlayeriYukariAsagiHareketi()
    {
        rb.velocity=new Vector2(0,
        Input.GetAxis("VerticalPlayerRight")* 10f);
    }
}
