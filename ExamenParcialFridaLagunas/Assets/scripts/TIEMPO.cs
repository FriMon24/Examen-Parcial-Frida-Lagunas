using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIEMPO : MonoBehaviour
{
    public class time : MonoBehaviour
    {
        void Pause()
        {
            Time.timeScale = 0;
        }

        void Resume()
        {
            Time.timeScale = 1;
        }
    }
}
