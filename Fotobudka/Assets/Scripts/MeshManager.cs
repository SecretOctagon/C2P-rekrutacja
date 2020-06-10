using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MeshManager : MonoBehaviour
{
    public GameObject loadingText;
    // [HideInInspector]
    public GameObject[] sceneMeshes;
    public Transform spawnParent;
    public int currentMesh;

    private void Start()
    {
        MeshByIndex(0);
        loadingText.SetActive(false);
    }

    public void Next()
    {
        sceneMeshes[currentMesh].SetActive(false);
        currentMesh++;
        while (currentMesh > sceneMeshes.Length - 1)
            currentMesh -= sceneMeshes.Length;
        sceneMeshes[currentMesh].SetActive(true);
    }
    public void Back()
    {
        sceneMeshes[currentMesh].SetActive(false);
        currentMesh--;
        while (currentMesh < 0)
            currentMesh += sceneMeshes.Length;
        sceneMeshes[currentMesh].SetActive(true);
    }
    public void MeshByIndex(int index)
    {
        currentMesh = index;
        for (int i = 0; i < sceneMeshes.Length; i++)
            sceneMeshes[i].SetActive(i == index);
    }
}
