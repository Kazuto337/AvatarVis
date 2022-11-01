using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    private Material Mat;
    [SerializeField] private Material otherMat;
    [SerializeField] private GameObject region;
    private bool hovered;

    void Start()
    {
        Mat = region.GetComponent<MeshRenderer>().material;
    }

    private void OnMouseEnter()
    {
        if(Brain.brainCode.onCanvasDisplayed)
            return;
        region.transform.localScale *= 1.2f;
        Mat.color += otherMat.color;
    }

    private void OnMouseExit()
    {
        region.transform.localScale /= 1.2f;
        Mat.color -= otherMat.color;
    }
}
