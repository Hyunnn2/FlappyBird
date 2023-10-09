using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int sc = 0; //static은 클래스 밖에서도 사용가능
    public static int bestsc = 0;

    // Start is called before the first frame update
    void Start()
    {
        sc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = sc.ToString();
    }
}
