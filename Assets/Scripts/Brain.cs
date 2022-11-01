using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public static Brain brainCode;
    public bool onCanvasDisplayed;
    public epocas epocaOn;
    public region regionActiva;

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

    private void Start()
    {
        brainCode = this;
    }

    public void BotonGastro()
    {
        switch (regionActiva)
        {
            case region.aguaSur:
                break;
            case region.aguaNorte:
                break;
            case region.fuego:
                break;
            case region.tierra:
                break;
            case region.aire:
                break;
            
            default:
                break;
        }
    }

    public void BotonArteCtrl()
    {
        
    }
}
