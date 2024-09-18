using System.Collections; // Koleksiyonlar için gerekli kütüphane.
using System.Collections.Generic; // Generic koleksiyonlar için gerekli kütüphane.
using UnityEngine; // Unity motoru için gerekli kütüphane.

public class soundManager : MonoBehaviour // soundManager sınıfı, MonoBehaviour'dan türetilir.
{
    // AudioSource bileşeni, sesleri çalmak için kullanılır.
    AudioSource audioSource;

    // Oyun içinde çalınacak ses dosyaları.
    // public AudioClip backgroundMusic; // Arka plan müziği için (şu an kullanılmıyor).
    public AudioClip topSesi; // Top sesi için ses dosyası.
    public AudioClip skorSesi; // Skor sesi için ses dosyası.

    // Start metodu, oyun başladığında bir kez çağrılır.
    void Start()
    {
        // Bu nesnenin AudioSource bileşenini al ve audioSource değişkenine ata.
        audioSource = GetComponent<AudioSource>();
    }

    // Update metodu, her frame'de bir kez çağrılır. (Şu an kullanılmıyor)
    void Update()
    {
    }

    // Arka plan müziği oynatma metodu (şu an kullanılmıyor).
    // public void BackgroundMusicOynat()
    // {
    //     audioSource.clip = backgroundMusic; // Arka plan müziğini belirle.
    //     audioSource.loop = true; // Müziğin döngüde çalmasını sağla.
    //     audioSource.volume = 1f; // Ses seviyesini ayarla.
    //     audioSource.Play(); // Müziği çalmaya başla.
    // }

    // Top sesi çalmak için kullanılan metod.
    public void TopSesiniOynat()
    {
        // Sesin döngüde çalmamasını sağlar.
        audioSource.loop = false;
        
        // Ses seviyesini ayarla.
        audioSource.volume = 1f;
        
        // topSesi ses dosyasını çal.
        audioSource.PlayOneShot(topSesi); // Kısa ses efektleri için "PlayOneShot" kullanılır.
    }

    // Skor sesi çalmak için kullanılan metod.
    public void SkorSesiniOynat()
    {
        // Sesin döngüde çalmamasını sağlar.
        audioSource.loop = false;

        // Ses seviyesini ayarla.
        audioSource.volume = 1f;

        // skorSesi ses dosyasını çal.
        audioSource.PlayOneShot(skorSesi); // Kısa ses efektleri için "PlayOneShot" kullanılır.
    }
}
