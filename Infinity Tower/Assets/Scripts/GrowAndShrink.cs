using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class GrowAndShrink : MonoBehaviour {
    
    public GameObject growObject;
    
    public float maxHeight;
    public float speed;
    
    private Transform growTransform;
    
    private Vector3 maxSize;
    private Vector3 startSize;
    
	// Use this for initialization
	void Start () {
        growTransform = growObject.transform;
        startSize = growTransform.localScale;
        maxSize = new Vector3(startSize.x, Random.Range(1,maxHeight), startSize.z);
        
        Destroy(gameObject, 60);
	}
	
	// Update is called once per frame
	void Update () {
        //growTransform.localScale = Vector3.Lerp(growTransform.localScale, new Vector3(1.0f,10.0f,1.0f) , 0.5f * Time.deltaTime);
        growTransform.localScale = Vector3.MoveTowards(growTransform.localScale, maxSize, Random.Range(2.0f,speed) * Time.deltaTime);
        //growTransform.localScale = new Vector3(startSize.x , PingPong(Time.time * speed, startSize.y, maxSize.y) , startSize.z);
	}
    
    
    float PingPong(float time, float min, float max){
        return Mathf.PingPong(time, max-min) + min;
    }
    

}
