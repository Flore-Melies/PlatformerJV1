using TMPro;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{

    [SerializeField] private TMP_InputField input;
    [SerializeField] private TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        //input.interactable = false;
        //text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayText(string arg)
    {
        //Debug.Log(arg);
        var number = int.Parse(arg);
        Debug.Log(number);
    }

    public void DisplaySlider(float arg)
    {
        Debug.Log(arg);
    }
}
