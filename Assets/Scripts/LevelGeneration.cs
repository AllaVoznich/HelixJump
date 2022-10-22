using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float Distance;
    public Transform FinishPlatform;
    public Transform CylinderRoot;

    private void Awake()
    {
        int platformsCount = Random.Range(MinPlatforms, MaxPlatforms+1);

        for (int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = Random.Range(0, PlatformPrefabs.Length);

            GameObject platformPrefab = i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if (i > 0)
             platform.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }

        FinishPlatform.localPosition = CalculatePlatformPosition(platformsCount);

        CylinderRoot.localScale = new Vector3(1, platformsCount * Distance, 1);
    }

    public Vector3 CalculatePlatformPosition(int platformIndex)
    {
        return new Vector3(0, -Distance * platformIndex, 0);
    }
}
