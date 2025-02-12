using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.XR; 

public class MagnifiedCameraController : MonoBehaviour 
{ 
	public Transform mainCamera; 
	// Start is called before the first frame update 
	void Start() {
	} 

	// Update is called once per frame 
	void Update() 
	{ transform.rotation = Quaternion.LookRotation(transform.parent.position - mainCamera.position, transform.parent.up); 
	}

}