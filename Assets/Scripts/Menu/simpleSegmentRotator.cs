using UnityEngine;
using System.Collections;

public class simpleSegmentRotator : MonoBehaviour {

    [SerializeField]
    float speed = 1f;
    void Start()
    {
        speed = ((speed*0.25f) * Random.value) + (speed*0.75f);
    }
	void Update () {
        transform.Rotate(0, 0, speed * Time.deltaTime); 
	}
}
