using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerLeft2 sınıfı, bir oyuncunun hareketini kontrol eden bir MonoBehaviour sınıfıdır.
public class PlayerRight : MonoBehaviour
{
    // Rigidbody2D bileşeni, fiziksel etkileşimler için kullanılır.
    Rigidbody2D rb;

    // Start metodu, oyun başladığında bir kez çağrılır.
    void Start()
    {
        // Bu nesnenin Rigidbody2D bileşenini al ve rb değişkenine ata.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update metodu, her frame'de bir kez çağrılır.
    void Update()
    {
        // Kullanıcıdan gelen girişle yukarı veya aşağı hareketi kontrol et.
        TuslarlaYukariAsagiHareket();
    }

    // Kullanıcı girişi ile yukarı veya aşağı hareketi kontrol eden metod.
    void TuslarlaYukariAsagiHareket()
    {
        // rb.velocity değerini güncelle, yalnızca Y ekseninde hareket et.
        rb.velocity = new Vector2(0, Input.GetAxis("VerticalPlayerLeft") * 10);
    }

    //-------------------------------------------
    
    // Aşağıya hareket eden otomatik bir metod.
    void PlayerOtoYukariHareketi()
    {
        // Y ekseninde yukarıya doğru sabit bir hızda hareket et.
        rb.velocity = new Vector2(0, -5);
    }

    // Yukarıya hareket eden otomatik bir metod.
    void PlayerOtoAsagiHareketi()
    {
        // Y ekseninde aşağıya doğru sabit bir hızda hareket et.
        rb.velocity = new Vector2(0, 5);
    }

    // Kullanıcı girişi ile sola veya sağa hareketi kontrol eden metod.
    void TuslarlaSolaSagaHareket()
    {
        // rb.velocity değerini güncelle, yalnızca X ekseninde hareket et.
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), 0);
    }

    // Kullanıcı girişi ile yukarı, aşağı, sola veya sağa hareketi kontrol eden metod.
    void TuslarlaYukariAsagiSagaSolaHareket()
    {
        // rb.velocity değerini güncelle, hem X hem de Y ekseninde hareket et.
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
