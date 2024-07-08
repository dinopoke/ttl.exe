using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    float fps;

    [SerializeField] TextMeshProUGUI fpsText;
    [SerializeField] TextMeshProUGUI timeText;

    public GameObject mascot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fps = 1f / Time.unscaledDeltaTime;
        timeText.text = Time.time.ToString();
        Debug.Log(timeText.text);
        fpsText.text = fps.ToString();

        if(Input.GetKey(KeyCode.Space)){
            Texture2D frame = new Texture2D(1234,1234);
            frame.Apply();
            Debug.Log("hehe");
        }

    }
}
