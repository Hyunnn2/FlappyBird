using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreup : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        score.sc++;
    }
}
