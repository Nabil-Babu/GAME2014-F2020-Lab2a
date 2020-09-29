using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text sceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel; 
   
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                //sceneLabel.text = "Landscape Left";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(383.0f,-105.0f,0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-378.0f,-105.0f,0f);
                break;
            case DeviceOrientation.LandscapeRight:
                //sceneLabel.text = "Landscape Right";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(246.0f,-105.0f,0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-498.0f,-105.0f,0f);
                break;
            case DeviceOrientation.Portrait:
                //sceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(246.0f,-196.0f,0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-364.0f,-196.0f,0f);
                break;
            case DeviceOrientation.Unknown:
                //sceneLabel.text = "Unknown";
                break;

        }
    }
}
