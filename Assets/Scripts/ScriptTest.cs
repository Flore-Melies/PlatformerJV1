using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
        Debug.Log("Bonjour");
    }
}
