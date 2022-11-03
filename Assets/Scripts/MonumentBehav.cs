using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonumentBehav : MonoBehaviour
{
    [SerializeField] List<GameObject> monuments;
    [SerializeField] Camera cameraMap, cameraMonuments;


    public static MonumentBehav Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else Instance = this;
    }
    public void SetMonumentMesh(Status index)
    {
        cameraMap.gameObject.SetActive(false);
        cameraMonuments.gameObject.SetActive(true);
        _status = index;
        switch (_status)
        {
            case Status.temploSanacion:
                monuments[0].gameObject.SetActive(true);
                break;
            case Status.naufragio:
                monuments[1].gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
    public void ResetMonuments()
    {
        cameraMap.gameObject.SetActive(true);
        cameraMonuments.gameObject.SetActive(false);

        foreach (GameObject item in monuments)
        {
            item.SetActive(false);
        }
    }
    public enum Status
    {
        temploSanacion=0, naufragio=1
    }
    public Status _status;
}
