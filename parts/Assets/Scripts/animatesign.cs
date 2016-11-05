using UnityEngine;
using System.Collections;

public class animatesign : MonoBehaviour {
    
    public Animation animation1;
    public Animation animationTrain;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            animation1.Play("rotate_right");
            animationTrain.Play("animate_wheel");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            animation1.Play("rotate_left");
            animationTrain.Play("animate_wheel");
        }

    }
}
