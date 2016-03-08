using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GameController : MonoBehaviour
{
    void Awake()
    {
        DOTween.Init( true, true, LogBehaviour.ErrorsOnly );
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
