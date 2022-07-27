using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] int cubesNumber;
    [SerializeField] float maxSize;

    GameObject[] _cubes;

    private void Start()
    {
        _cubes = new GameObject[512];

        for (int i = 0; i < cubesNumber; i++)
        {
            _cubes[i] = Instantiate(cube, new Vector3(i/3, 0, 0), Quaternion.identity);
        }
    }
    private void Update()
    {
        for(int i = 0; i < _cubes.Length; i++)
        {
            _cubes[i].transform.localScale = new Vector3(1, AudioComponent.data[i]*maxSize, 1);
        }
    }
}
