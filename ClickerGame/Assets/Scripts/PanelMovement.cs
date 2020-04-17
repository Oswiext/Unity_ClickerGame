using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMovement : MonoBehaviour {

    public GameObject ButtonA;
    public GameObject ButtonB;

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 posNext;

    //serialize so we can watch it in inspector
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformA;

    [SerializeField]
    private Transform transformB;

    public void Start()
    {
        ButtonB.SetActive(false);
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        posNext = posB;
    }

    public void Update()
    {
        //Move();
    }

    public void MoveA()
    {
        ButtonA.SetActive(false);
        ButtonB.SetActive(true);
        posNext = posB;
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, posNext, speed * Time.deltaTime);
    }

    public void MoveB()
    {
        ButtonA.SetActive(true);
        ButtonB.SetActive(false);
        posNext = posA;
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, posNext, speed * Time.deltaTime);
     }


}
