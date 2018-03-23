using UnityEngine;

public class Values : MonoBehaviour {


	public float rotationRate;
	public float rotationSpeed;
	public static float rotationRate_;
	public static float rotationSpeed_;

	void Awake () {
		rotationRate_ = rotationRate;
		rotationSpeed_ = rotationSpeed;
	}
}
