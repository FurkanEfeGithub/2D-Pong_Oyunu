using System.Collections; // Koleksiyonlar için gerekli kütüphane.
using System.Collections.Generic; // Generic koleksiyonlar için gerekli kütüphane.
using UnityEngine; // Unity motoru için gerekli kütüphane.

public class GameManager : MonoBehaviour // GameManager2 sınıfı, MonoBehaviour'dan türetilir.
{
    // Sol ve sağ oyuncuların ve topun Transform bileşenleri için referanslar.
    public Transform playerLeftTransformu, playerRightTransformu, ballTransformu;
    
    // GameManager'nin static örneği. Diğer sınıflardan erişim için kullanılır.
    public static GameManager gameManager;

    // Awake metodu, script yüklendiğinde ilk olarak çağrılır.
    void Awake()//Awake METODU,START METODUNDAN ÖNCE ÇAGRILIR.ADINI DEGİŞTİREMEZSİN.
    {
        // gameManager2 değişkenini bu sınıfın örneğine atar.
        gameManager2 = this;
    }

    // Start metodu, oyun başladığında bir kez çağrılır.
    void Start()
    {
        // Başlangıçta yapılacak işlemler buraya yazılabilir.
    }

    // Update metodu, her frame'de bir kez çağrılır.
    void Update()
    {
        // Frame bazında sürekli kontrol edilecek işlemler buraya yazılabilir.
    }

    // Oyun yeniden başladığında oyuncuların ve topun pozisyonlarını ayarlayan metod.
    public void OyunYenidenBasladigindaPozisyonlar()
    {
        // Sol oyuncunun pozisyonunu ayarla.
        playerLeftTransformu.position = new Vector2(-8, 0);
        
        // Sağ oyuncunun pozisyonunu ayarla.
        playerRightTransformu.position = new Vector2(8, 0);
        
        // Topun başlangıç hareketini sağla (Ball2 scriptinde tanımlı).
        ballTransformu.GetComponent<Ball>().BaslangictaTopSagaGitsin();//Ball.cs scripti
        
        // Topun pozisyonunu sıfırla (Ball2 scriptinde tanımlı).
        ballTransformu.GetComponent<Ball>().OyunYenidenBasladigindaTopunPozisyonu();
    }
}
