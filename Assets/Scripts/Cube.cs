using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] float maxSize;
    [SerializeField] int band;
    void Start()
    {

    }

    void Update()
    {
        transform.localScale = new Vector3(0.2f, AudioComponent.compactedData[band] * maxSize, 0.2f);
    }
}
