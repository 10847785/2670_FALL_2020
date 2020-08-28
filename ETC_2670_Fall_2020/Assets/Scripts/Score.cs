using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public IntData scoreValue;

    private Text text;
    
    // Start is called before the first frame update
    private void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update() => text.text = scoreValue.value.ToString();
}
