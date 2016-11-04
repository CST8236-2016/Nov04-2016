using UnityEngine;
using System.Collections;

public class TranslateObject : MonoBehaviour {

  [HideInInspector]
  public int value;

  public Vector3 direction;

  void Awake() {

  }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame at a variable time interval.
	void Update () {
    Transform transformComponent = GetComponent<Transform>();

    transform.position += direction * Time.deltaTime;
	}

  // Update is called once per frame after all other updates have finished.
  void LateUpdate() {
  }
  
  // Update is called once per frame at a fixed time interval.
  void FixedUpdate() {
  }

  /* OnDestroy is called when this component (and its parent GameObject)
   * are being destroyed. */
  void OnDestroy() {

  }
}
