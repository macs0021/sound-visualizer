using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioComponent : MonoBehaviour
{
    AudioSource audioSource;
    public static float[] data;
    void Start()
    {
        data = new float[512];
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetData();
    }
    void GetData()
    {
        audioSource.GetSpectrumData(data, 0, FFTWindow.Blackman);
    }
}
