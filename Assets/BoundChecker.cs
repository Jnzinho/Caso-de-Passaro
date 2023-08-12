using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Detects manually if obj is being seen by the main camera

    public GameObject obj;
    BoxCollider2D objCollider;
    public LogicScript logic;
    Camera cam;
    Plane[] planes;
    public BirdScript birdScript;

    void Start()
    {
        cam = Camera.main;
        planes = GeometryUtility.CalculateFrustumPlanes(cam);
        objCollider =  obj.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Debug.Log(birdScript.birdIsAlive);
        if (!GeometryUtility.TestPlanesAABB(planes, objCollider.bounds) && birdScript.birdIsAlive)
        {
            birdScript.birdIsAlive = false;
            logic.gameOver();
        }
    }
}
