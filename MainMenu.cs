using System.Collections; // Koleksiyonlar için gerekli kütüphane.
using System.Collections.Generic; // Generic koleksiyonlar için gerekli kütüphane.
using UnityEngine; // Unity motoru için gerekli kütüphane.
using UnityEngine.SceneManagement; // Sahne yönetimi için gerekli kütüphane.

public class MainMenu : MonoBehaviour // MainMenu sınıfı, MonoBehaviour'dan türetilir.
{
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

    // Oyun başlatma butonuna tıklandığında çağrılan metod.
    public void PlayButton()
    {
        // 1 numaralı sahneyi yükle (genellikle oyun sahnesi).
        SceneManager.LoadScene(1);
    }

    // Çıkış butonuna tıklandığında çağrılan metod.
    public void QuitButton()
    {
        // Uygulamayı kapat.
        Application.Quit();
    }
}
