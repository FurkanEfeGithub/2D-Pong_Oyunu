using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ball sınıfı, topun hareketini ve etkileşimlerini kontrol eden bir MonoBehaviour sınıfıdır.
public class Ball : MonoBehaviour
{
    // Rigidbody2D bileşeni, topun fiziksel özelliklerini kontrol etmek için kullanılır.
    Rigidbody2D rb;
    
    // SoundManager scriptine referans tutan değişken.//Scriptim soundManager//soundManager scriptine burdan ulaşıyorum.
    soundManager soundManagerScript;

    // Start metodu, oyun başladığında bir kez çağrılır.
    void Start()
    {
        // Bu nesnenin Rigidbody2D bileşenini al ve rb değişkenine ata.
        rb = GetComponent<Rigidbody2D>();
        
        // Oyunun başlangıcında topun sağa gitmesini sağlar.
        BaslangictaTopSagaGitsin();
        
        // Oyun yeniden başladığında topun pozisyonunu sıfırlar.
        OyunYenidenBasladigindaTopunPozisyonu();
        
        // SoundManager nesnesini bul ve ilgili scripti al.//Scriptimin adı soundManager.
        soundManagerScript = GameObject.Find("soundManager").GetComponent<soundManager>();
    }

    // Update metodu, her frame'de bir kez çağrılır. (Şu an kullanılmıyor)
    void Update()
    {
    }

    // Başlangıçta topun sağa doğru hareket etmesini sağlayan metod.
    public void BaslangictaTopSagaGitsin()
    {
        // Topun X ekseninde 10 birim/saniye hızı ile hareket etmesini sağla.
        rb.velocity = new Vector2(10f, 0);
    }

    // Oyun yeniden başladığında topun pozisyonunu sıfırlar.
    public void OyunYenidenBasladigindaTopunPozisyonu()
    {
        // Topun pozisyonunu (0, 0) koordinatına ayarla.
        transform.position = new Vector2(0, 0);
    }

    // Topun hızını sabitleyen metod.
    void TopunHiziniSabitle()
    {
        //TOPUN HIZINI NORMALİZE EDİP SABİT BİR DEGERE AYARLA
        // Topun mevcut hızını normalizeVelocity değişkenine ata.
        Vector2 normalizeVelocity = rb.velocity;
    
        normalizeVelocity.Normalize();//VECTORUN AÇISINI DEGİŞTİRMEDEN UZUNLUGUNU 1 YAPAR.
        
        // Topun hızını sürekli 10 birim/saniye olacak şekilde ayarla.
        normalizeVelocity *= 10;
        
        // Güncellenmiş hızı Rigidbody'ye ata.
        rb.velocity = normalizeVelocity;
    }

    // Top bir nesneyle çarpıştığında çağrılan metod.
    void OnCollisionEnter2D(Collision2D temas)
    {
        // Eğer çarpıştığı nesne "Player" ise
        if (temas.gameObject.tag == "Player")
        {
            // Oyuncunun Y eksenindeki hızını al.
            float playerinVelocitY = temas.gameObject.GetComponent<Rigidbody2D>().velocity.y;

            // Eğer oyuncu durmuyorsa
            if (playerinVelocitY != 0)
            {
                // Topun Y eksenindeki hızını oyuncunun Y eksenindeki hıza eşitle.
                rb.velocity = new Vector2(rb.velocity.x, playerinVelocitY);
            }

            // Topun hızını sabitle.
            TopunHiziniSabitle();

            // Ses efektini çal.
            soundManagerScript.TopSesiniOynat();
        }

        // Eğer çarpıştığı nesne "DuvarLeft" ise
        if (temas.gameObject.tag == "DuvarLeft")
        {
            // Sağ skoru artır.
            SkorManager.rightSkor++;
            // Oyun yeniden başladığında pozisyonları ayarla.
            GameManager.gameManager.OyunYenidenBasladigindaPozisyonlar();
            // Ses efektini çal.
            soundManagerScript.SkorSesiniOynat();
        }

        // Eğer çarpıştığı nesne "DuvarRight" ise
        if (temas.gameObject.tag == "DuvarRight")
        {
            // Sol skoru artır.
            SkorManager.leftSkor++;
            // Oyun yeniden başladığında pozisyonları ayarla.
            GameManager.gameManager.OyunYenidenBasladigindaPozisyonlar();
            // Ses efektini çal.
            soundManagerScript.SkorSesiniOynat();
        }
    }
}
