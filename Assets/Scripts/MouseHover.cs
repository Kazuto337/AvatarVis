using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour,MouseClickInterface
{
    private Material Mat;
    [SerializeField] private Material otherMat;
    [SerializeField] private GameObject region;
    private bool clickOn;

    void Start()
    {
        Mat = region.GetComponent<MeshRenderer>().material;
    }

    /*private void Update()
    {
        clickOn = Input.GetMouseButton(0);
    }*/

    private void OnMouseEnter()
    {
        /*if(clickOn)
            return;*/
        region.transform.localScale *= 1.2f;
        //gameObject.transform.localScale += Vector3.up * 2;
        Mat.color += otherMat.color;
    }

    private void OnMouseExit()
    {
        /*if(clickOn)
            return;*/
        region.transform.localScale /= 1.2f;
        //gameObject.transform.localScale -= Vector3.up * 2;
        //Mat.color = _color;
        Mat.color -= otherMat.color;
    }

    private void OnMouseDown()
    {
        Click();
    }

    public void Click()
    {
        Debug.Log("xd");
    }
}
