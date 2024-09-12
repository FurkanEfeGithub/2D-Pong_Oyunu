using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerLeftTransformu,playerRightTransformu,ballTransformu;
    public static GameManager gameManager;//Ball.cs scriptinden bu scripte ulaşabilmek için.
    void Awake()//Awake METODU,START METODUNDAN ÖNCE ÇAGRILIR.ADINI DEGİŞTİREMEZSİN.//Karmaşık Projelerde: Eğer bir oyun yöneticiniz varsa ve bu yöneticinin oyun boyunca erişilmesi gereken tek bir örneği olması gerekiyorsa, Awake() metodunu kullanarak bu referansı kurabilirsiniz. Örneğin, Singleton deseni
    {
        gameManager=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunYenidenBasladigindaPosizyonlar()
    {
        playerLeftTransformu.position=new Vector3(-8,0,0);
        playerRightTransformu.position=new Vector3(8,0,0);
        ballTransformu.GetComponent<Ball>().BaslangictaTopSagaGitsin();//Ball.cs scriptindeki BaslangictaTopSagaGitsin() metodu.
        ballTransformu.GetComponent<Ball>().OyunYenidenBasladigindaBallPozisyonu();
    }
}
