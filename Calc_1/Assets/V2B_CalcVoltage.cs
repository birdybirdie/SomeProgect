using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class V2B_CalcVoltage : MonoBehaviour {

    private InputField eInput1, eInput2;
    private InputField iInput1, iInput2;
    public void calcFunc ()
    {
        eInput1= GameObject.Find("InputField_E1").GetComponent<InputField>();
        eInput2 = GameObject.Find("InputField_E2").GetComponent<InputField>();

        double E1 = double.Parse (eInput1.text);
        double E2 = double.Parse (eInput2.text);

        Debug.Log("e- input get parsed");

        iInput1 = GameObject.Find("InputField_I1").GetComponent<InputField>();
        iInput2 = GameObject.Find("InputField_I2").GetComponent<InputField>();

        double I1 = double.Parse(iInput1.text);
        double I2 = double.Parse(iInput2.text);

        Debug.Log("i- input get parsed");


    }
}
