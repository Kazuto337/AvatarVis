using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Brain : MonoBehaviour
{
    public static Brain brainCode;
    public bool onCanvasDisplayed;
    public GameObject canvasObj;
    public epocas epocaOn;
    public region regionActiva;
    public estados estadoActual;

    private void Awake()
    {
        brainCode = this;
    }
    
    private void Update()
    {
        switch (estadoActual)
        {
            case estados.navegando:
                
                break;
            case estados.zoom:
                
                if (onCanvasDisplayed && Input.GetKeyDown(KeyCode.Escape))
                {
                    canvasObj.SetActive(false);
                    onCanvasDisplayed = false;
                    estadoActual = estados.navegando;
                }
                break;
        }
        
    }
    
    public enum estados
    {
        navegando,
        zoom
    }

    public enum region
    {
        aguaSur,
        aguaNorte,
        fuego,
        aire,
        tierra,
        Ninguno
    }
    
    public enum epocas
    {
        Roku,
        Aang,
        Korra
    }
}
