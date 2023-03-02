using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botnreinicio : MonoBehaviour
{
    public string reinicio;
    // Update is called once per frame //reinicio
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(reinicio);
        }
    }
}
