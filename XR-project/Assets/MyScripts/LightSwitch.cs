using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
	public Light light;
	public InputActionReference action;
	private bool isChanged = false;

	void Start()
	{
		light = GetComponent<Light>();
		action.action.Enable();
		action.action.performed += ChangeColor;
	}

	void ChangeColor(InputAction.CallbackContext
context)
	{
		if (isChanged) {
			light.color = Color.white;
			isChanged = false;
		}

		else {
			light.color = Color.blue;
			isChanged = true;
		}
	}
}
