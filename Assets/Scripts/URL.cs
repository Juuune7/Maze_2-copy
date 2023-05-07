using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class URL : MonoBehaviour
{
    public string Url;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
        Application.OpenURL(Url);
        }
    }
}

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Return))
    //     {
    //         gameStart(); 
    //     }
    // }



// public class URL : MonoBehaviour
// {
//     public string Url;

//     public void Open()
//     {
//         Application.OpenURL(Url);
//     }
// }
