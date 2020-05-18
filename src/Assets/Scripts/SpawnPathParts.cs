using UnityEngine;

public class SpawnPathParts : MonoBehaviour
{
    public GameObject prefab;
    public Transform anchor;
    public int amountToSpawn = 20;

    void Start()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            Instantiate(prefab, anchor);
        }
    }
}
