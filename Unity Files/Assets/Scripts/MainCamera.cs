using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    private Transform mainCamera;
    private Transform hero;
    private GameObject player;
    Vector3 offset;
    // Use this for initialization
    public void Start()
    {

        mainCamera = GetComponent<Transform>();
        offset = mainCamera.position;
        player = GameObject.Find("Ball");
        hero = player.GetComponent<Transform>();

    }
    public void Update()
    {
        mainCamera.position = hero.position + offset;
    }

}
