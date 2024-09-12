using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerLeftPosition,playerRightPosition,ballPosition;
    public static GameManager gameManager;//Ball.cs scriptinden bu scripte ulaşabilmek için.
    void Awake()//Awake METODU,START METODUNDAN ÖNCE ÇAGRILIR.ADINI DEGİŞTİREMEZSİN.
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
        playerLeftPosition.position=new Vector3(-8,0,0);
        playerRightPosition.position=new Vector3(8,0,0);
        ballPosition.GetComponent<Ball>().BaslangictaTopSagaGitsin();//Ball.cs scriptindeki BaslangictaTopSagaGitsin() metodu.
        ballPosition.GetComponent<Ball>().OyunYenidenBasladigindaBallPozisyonu();
    }
}
