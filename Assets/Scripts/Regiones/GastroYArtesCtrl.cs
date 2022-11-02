using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GastroYArtesCtrl : MonoBehaviour
{
    [SerializeField] private Image GastroImage;
    [SerializeField] private string arteCrtl;
    [SerializeField] private Image arteCtrlImage;
    [SerializeField] private GameObject cuerpo;
    [SerializeField] private GameObject titulo;
    [SerializeField] private GameObject botonGastro;
    [SerializeField] private GameObject botonArte;
    [SerializeField] private GameObject botonCerrar;

    
    [Header("Agua Sur")]
    [SerializeField] private Image GastroImage_AguaSur;
    [SerializeField] private string arteCrtl_AguaSur;
    [SerializeField] private Image arteCtrlImage_AguaSur;
    [Header("Agua Norte")]
    [SerializeField] private Image GastroImage_AguaNorte;
    [SerializeField] private string arteCrtl_AguaNorte;
    [SerializeField] private Image arteCtrlImage_AguaNorte;
    [Header("Agua Fuego")]
    [SerializeField] private Image GastroImage_Fuego;
    [SerializeField] private string arteCrtl_Fuego;
    [SerializeField] private Image arteCtrlImage_Fuego;
    [Header("Tierra")]
    [SerializeField] private Image GastroImage_Tierra;
    [SerializeField] private string arteCrtl_Tierra;
    [SerializeField] private Image arteCtrlImage_Tierra;
    [Header("Aire")]
    [SerializeField] private Image GastroImage_Aire;
    [SerializeField] private string arteCrtl_Aire;
    [SerializeField] private Image arteCtrlImage_Aire;

    public void GastronomiaBoton()
    {
        switch (Brain.brainCode.regionActiva)
        {
            case Brain.region.aguaSur:
                GastroImage = GastroImage_AguaSur;
                break;
            case Brain.region.aguaNorte:
                GastroImage = GastroImage_AguaNorte;
                break;
            case Brain.region.fuego:
                GastroImage = GastroImage_Fuego;
                break;
            case Brain.region.tierra:
                GastroImage = GastroImage_Tierra;
                break;
            case Brain.region.aire:
                GastroImage = GastroImage_Aire;
                break;
        }
        //==============================//
            //Activar y apagar botones
        //==============================//
    }

    public void ArtesCtrlBoton()
    {
        switch (Brain.brainCode.regionActiva)
        {
            case Brain.region.aguaSur:
                arteCrtl = arteCrtl_AguaSur;
                arteCtrlImage = arteCtrlImage_AguaSur;
                break;
            case Brain.region.aguaNorte:
                arteCrtl = arteCrtl_AguaNorte;
                arteCtrlImage = arteCtrlImage_AguaNorte;
                break;
            case Brain.region.fuego:
                arteCrtl = arteCrtl_Fuego;
                arteCtrlImage = arteCtrlImage_Fuego;
                break;
            case Brain.region.tierra:
                arteCrtl = arteCrtl_Tierra;
                arteCtrlImage = arteCtrlImage_Tierra;
                break;
            case Brain.region.aire:
                arteCrtl = arteCrtl_Aire;
                arteCtrlImage = arteCtrlImage_Aire;
                break;
        }
        //==============================//
            //Activar y apagar botones
        //==============================//
    }
}
