using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
    private float verticalSize;
    private float horizontalSize;
    public GroundBlock block;

    private double mapX = 100.0;
    private double mapY = 100.0;

    private float minX;
    private float maxX;
    private float minY;
    private float maxY;

	// Use this for initialization
	void Start () {
        verticalSize = Camera.main.orthographicSize;
        horizontalSize = verticalSize * Screen.width / Screen.height;

        minX = horizontalSize - (float)mapX / 2.0f;
        maxX = (float)mapX / 2.0f - horizontalSize;
        minY = verticalSize - (float)mapY / 2.0f;
        maxY = (float)mapY / 2.0f - verticalSize;

        for (int i = 0; i < 25; i++)
        {
            Instantiate(block, new Vector3((i * 1f), minY, 0),Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
