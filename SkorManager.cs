using System.Collections; // Koleksiyonlar için gerekli kütüphane.
using System.Collections.Generic; // Generic koleksiyonlar için gerekli kütüphane.
using UnityEngine; // Unity motoru için gerekli kütüphane.
using UnityEngine.UI; // UI bileşenleri için gerekli kütüphane.

public class SkorManager : MonoBehaviour // SkorManager sınıfı, MonoBehaviour'dan türetilir.
{
    // Sol ve sağ skorları göstermek için kullanılan UI metin bileşenleri.
    public Text leftSkor_tx, rightSkor_tx;
    
    // Sol ve sağ skor için static değişkenler. Diğer sınıflardan erişilebilir.
    public static float leftSkor, rightSkor;

    // Start metodu, oyun başladığında bir kez çağrılır.
    void Start()
    {
        // Sol ve sağ skorları başlangıçta 0 olarak ayarla.
        leftSkor = 0;
        rightSkor = 0;
    }

    // Update metodu, her frame'de bir kez çağrılır.
    void Update()
    {
        // Sol skoru metin bileşenine atar ve UI'da gösterir.
        leftSkor_tx.text = leftSkor.ToString();
        
        // Sağ skoru metin bileşenine atar ve UI'da gösterir.
        rightSkor_tx.text = rightSkor.ToString();
    }
}
