using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public GameObject[] models;
    public int loadModelIndex = 0;

    void Start()
    {
        Instantiate(models[loadModelIndex], transform);
    }
}
