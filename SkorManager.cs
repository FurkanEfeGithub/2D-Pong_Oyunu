using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorManager : MonoBehaviour
{
    public Text leftSkor_tx,rightSkor_tx;
    public static float leftSkor,rightSkor;
    // Start is called before the first frame update
    void Start()
    {
        leftSkor=0;
        rightSkor=0;
    }

    // Update is called once per frame
    void Update()
    {
        leftSkor_tx.text=leftSkor.ToString();
        rightSkor_tx.text=rightSkor.ToString();
    }
}
