using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject pathRoot;
    public void OnClick()
    {
        pathRoot.SetActive(!pathRoot.activeInHierarchy);
    }
}
