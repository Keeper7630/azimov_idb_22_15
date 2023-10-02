using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deactivation : MonoBehaviour
{
    public GameObject Testobj;
    public short i = 1;

    public void Deactivate()
    {
        if (i == 1) {
            Testobj.SetActive(false);
            i = 0;
        }
        else if (i == 0)
        {
            Testobj.SetActive(true);
            i = 1;
        }
    }
}
