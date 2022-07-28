using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioComponent : MonoBehaviour
{
    AudioSource audioSource;
    public static float[] data;
    public static float[] compactedData;
    void Start()
    {
        data = new float[512];
        compactedData = new float[8];
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetData();
        GetCompactedData();
    }
    void GetData()
    {
        audioSource.GetSpectrumData(data, 0, FFTWindow.Blackman);
    }
    void GetCompactedData()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += data[count] * (count + 1);
                count++;
            }
            average /= count;
            compactedData[i] = average * 10;
        }
    }
}
