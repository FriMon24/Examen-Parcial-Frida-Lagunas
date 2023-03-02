using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ingres : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text text;
    public int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = 27;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void correcto ()
    {
        if (resultado == 27) 
        {
            text.text = "correcto";
        }
         if (resultado > 27)
        {
            text.text = "incorrecto, reinicia la operacion";
        }
         else if (resultado <27)
        {
            text.text = "incorrecto reinicia la operacion";
        }

    }
    
}
