using UnityEngine;
using System.Collections;

public class simpleSegmentRotator : MonoBehaviour {

    [SerializeField]
    float speed = 1f;
	void Update () {
        transform.Rotate(0, 0, speed * Time.deltaTime); 
	}
}
