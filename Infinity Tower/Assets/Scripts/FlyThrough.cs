using UnityEngine;
using System.Collections;

public class FlyThrough : MonoBehaviour {

    public GameObject flyGroup;
    public Transform groundGroup;
    
    public float speed;
    public float tileSize;
    private Transform flyGroupTransform;
    
    private Vector3 startPos;

	// Use this for initialization
	void Start () {
	   flyGroupTransform = flyGroup.transform;
       startPos = groundGroup.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * speed, tileSize);
        groundGroup.position = startPos + Vector3.back * newPos;
        flyGroupTransform.position += Vector3.back * Time.deltaTime * speed;
	}
}
