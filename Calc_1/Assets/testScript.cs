using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class testScript : MonoBehaviour
{
    private Button  b31, b13;
    private Image b0;
    //private int edsSlider;

    public void changeColourFunc()
    {
       
        int edsSlider = (int)GameObject.Find("edsSlider").GetComponent<Slider>().value;

        // b0 = GameObject.Find("Button_nonEDS").GetComponent<Button>();
         b0 = GameObject.Find("GameObject_1").GetComponent<Image>();
        b31 = GameObject.Find("Button_E31").GetComponent<Button>();
        b13 = GameObject.Find("Button_E13").GetComponent<Button>();

        //b0.GetComponent<Image>().color = new Color(86, 79, 99, 255);
        //b31.GetComponent<Image>().color = new Color(86, 79, 99, 255);
        //b13.GetComponent<Image>().color = new Color(86, 79, 99, 255);

        switch (edsSlider)
        {
            case 0:
                Debug.Log("slider value = 0");
                b0.color = new Color(255, 0, 0, 255);
                break;

            case 1:
                Debug.Log("slider value = 1");
                b31.GetComponent<Image>().color = new Color(86, 79, 99, 255);
                break;

            case 2:
                Debug.Log("slider value = 2");
                b13.GetComponent<Image>().color = new Color(86, 79, 99, 255);
                break;          
        }
        
    }
}

/*
 public Button button ; // Drag & Drop the button in the inspector
     
     public void TurnRed()
     {
         ColorBlock colors = button.colors;
         colors.normalColor = Color.red;
         colros.highlightedColor = new Color32(255, 100, 100, 255);
         buttons.colors = colors;
     }
     


    public void changeColourFunc()
    {
       
        int edsSlider = (int)GameObject.Find("edsSlider").GetComponent<Slider>().value;

        b0 = GameObject.Find("Button_nonEDS").GetComponent<Button>();
        b31 = GameObject.Find("Button_E31").GetComponent<Button>();
        b13 = GameObject.Find("Button_E13").GetComponent<Button>();

        switch (edsSlider)
        {
            case 0:
                Debug.Log("slider value = 0");
                b0.GetComponent<Image>().color = new Color(0, 0, 0, 255);
                break;

            case 1:
                Debug.Log("slider value = 1");
                b31.GetComponent<Image>().color = new Color(0, 0, 0, 255);
                break;

            case 2:
                Debug.Log("slider value = 2");
                b13.GetComponent<Image>().color = new Color(0, 0, 0, 255);
                break;          
        }

    }
     */
