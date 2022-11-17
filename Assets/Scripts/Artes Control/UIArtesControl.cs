using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIArtesControl : MonoBehaviour
{
    public Transform paper;
    [SerializeField] List<Transform> nodes;
    [SerializeField] float duration;
    int nodesPos;
    private void Start()
    {
        DOTween.Init();
        //print(paper.position);
    }

    public void MovePaper()
    {
        nodesPos++;
        paper.DOMove(nodes[nodesPos].position , duration);
        //print(nodes[nodesPos].position.x + " , " + nodes[nodesPos].position.y);
        
    }

    public void ResetPaper()
    {
        nodesPos = 0;
        paper.DOMove(nodes[0].position, duration);
    }


}
