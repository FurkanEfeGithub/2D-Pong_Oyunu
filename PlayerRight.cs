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
    //--------------------KODU DAHA İYİ ANLAMAK İÇİN ÇEŞİTLİ VARYASYON METODLARIM-------------------
    void PlayerOtoYukariHareketi()
    {
        rb.velocity=new Vector2(0,-5);
    }
    void PlayerOtoAsagiHareketi()
    {
        rb.velocity=new Vector2(0,5);
    }
    void TuslarlaYukariAsagiHareket()
    {
        rb.velocity=new Vector2(0,
        Input.GetAxis("Vertical")*10);
    }
    void TuslarlaSolaSagaHareket()
    {
        rb.velocity=new Vector2(Input.GetAxis("Horizontal"),
        0);
    }
    void TuslarlaYukariAsagiSagaSolaHareket()
    {
        rb.velocity=new Vector2(Input.GetAxis("Horizontal"),
        Input.GetAxis("Vertical"));
    }
}
