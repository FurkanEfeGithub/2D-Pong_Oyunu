using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D=GetComponent<Rigidbody2D>();// TOPUN RİGİDBODY2D BİLEŞENİNİ rb2D'YE ATADIK.
        BaslangictaTopSagaGitsin();
        OyunYenidenBasladigindaBallPozisyonu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunYenidenBasladigindaBallPozisyonu()
    {
        transform.position=new Vector2(0,0);//Vector3.zero
    }
    public void BaslangictaTopSagaGitsin()
    {
        rb2D.velocity=new Vector2(10,0);
    }
    void OnCollisionEnter2D(Collision2D temas)
    {   
        if(temas.gameObject.tag=="Player")
        {
            float velocityY=temas.gameObject.GetComponent<Rigidbody2D>().velocity.y;//SÜREKLİ UZUN UZUN YAZMAMAK İÇİN velocityY 'DEGİŞKENİNE ATADIM.
            if(velocityY!=0)//Oyuncu durmuyorsa
            {
                // Topun y eksenindeki hızını Player'ın y eksenindeki hızına eşitle
                rb2D.velocity=new Vector2(rb2D.velocity.x,velocityY);
            }
            // Topun hızını normalize edip sabit bir değere ayarla
            Vector2 yeniVelocityY=rb2D.velocity;//TOPUN MEVCUT HİZİNİ yeniVelocityY ADINDA BİR DEGİŞKENE ATA.
            yeniVelocityY.Normalize();//VEKTORUN AÇISINI DEGİŞTİRMEDEN UZUNLUGUNU 1 YAPAR.
            yeniVelocityY=yeniVelocityY*10;//TOPUN HIZI SÜREKLİ 10 OLACAK.
            rb2D.velocity=yeniVelocityY;
        }
        else if(temas.gameObject.tag=="DuvarLeft")
        {
            SkorManager.rightSkor++;
            GameManager.gameManager.OyunYenidenBasladigindaPosizyonlar();
        }
        else if(temas.gameObject.tag=="DuvarRight")
        {
            SkorManager.leftSkor++;
            GameManager.gameManager.OyunYenidenBasladigindaPosizyonlar();
        }
    }
}
