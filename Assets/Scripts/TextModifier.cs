using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextModifier : MonoBehaviour
{
    private TextMeshProUGUI myTMP;

    // Start is called before the first frame update
    void Start()
    {
        myTMP = GetComponent<TextMeshProUGUI>();
    }

    public void ChangeText()
    {
        myTMP.text = "Bonjour";
    }

    // Update is called once per frame
    void Update()
    {
    }
}