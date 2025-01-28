using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut: MonoBehaviour
{
	public InputActionReference action;
	private Vector3 roomPosition;
	public Transform person;
   	private bool isInRoom = true;

    	void Start()
    	{
		roomPosition = person.position;
		action.action.Enable();
		action.action.performed += ChangeLocation;
    	}

    	void ChangeLocation(InputAction.CallbackContext
context)
    	{
		if (!isInRoom)
		{
            		person.position = roomPosition;
			isInRoom = true;
            	}
            	else
            	{
			person.position = new Vector3(0, 0, -65);
            		isInRoom = false;
		}
    	}
}

