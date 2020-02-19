using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
   [SerializeField]
    private string text;

    public string GetText()
    {
        return text;
    }
}
