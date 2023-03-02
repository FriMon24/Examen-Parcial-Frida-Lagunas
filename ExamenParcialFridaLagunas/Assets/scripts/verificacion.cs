using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class verificacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string verifi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            SceneManager.LoadScene(verifi);
        }

    }
   
}
