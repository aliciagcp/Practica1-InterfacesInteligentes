using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameObjectsScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects) {
            Debug.Log("Objeto: " + obj.name + ", Etiqueta: " + obj.tag);
        }
    }
}
