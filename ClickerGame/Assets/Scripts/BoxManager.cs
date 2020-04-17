using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour {

    public GameObject Box;

    public void Pressed()
    {
        Box.SetActive(false);
    }
}
