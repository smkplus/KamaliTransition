using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public List<Transform> list;
    
    public void Start(){
    Play();
    }

    public void Play()
    {
        StartCoroutine(PlayTransition());
    }

    IEnumerator PlayTransition()
    {
        yield return new WaitForSeconds(1.5f);

        foreach (var obj in list)
        {
            obj.DOScale(0, 1);
            yield return new WaitForSeconds(0.03f);
        }
    }
}