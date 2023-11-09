using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    GameObject fileManager;
    readFile rf;

    [SerializeField] private string enemyName;
    [SerializeField] private int enemyHealth;
    [SerializeField] private Transform enemyLocation;

    // Start is called before the first frame update
    void Start()
    {
        fileManager = GameObject.FindGameObjectWithTag("FileManager");
        rf = fileManager.GetComponent<readFile>();

        enemyName = rf.readFileAtOnce();

        Debug.Log("Name: " + enemyName);
    }
}
