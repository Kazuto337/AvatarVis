using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AguaSurCode : MonoBehaviour, MouseClickInterface
{
    [SerializeField] private RecursosRegiones recursos;
    [SerializeField] private Brain.region estaRegion;
    [SerializeField] private GameObject panelCanvas;
    [SerializeField] private TextMeshProUGUI nombreText;
    [SerializeField] private TextMeshProUGUI DescrpText;

    public void Click()
    {
        Brain.brainCode.onCanvasDisplayed = true;
        Brain.brainCode.regionActiva = estaRegion;
        // mover camara
        // poner musica
        
        switch (Brain.brainCode.epocaOn)
        {
            case Brain.epocas.Roku:
                nombreText.text = recursos.nombreRoku;
                DescrpText.text = recursos.descrpRoku;
                break;
            case Brain.epocas.Aang:
                nombreText.text = recursos.nombreAang;
                DescrpText.text = recursos.descrpAang;
                break;
            case Brain.epocas.Korra:
                nombreText.text = recursos.nombreKorra;
                DescrpText.text = recursos.descrpKorra;
                break;
        }
        
        setOnCanvas();
    }

    private void setOnCanvas()
    {
        panelCanvas.SetActive(true);
    }
}
