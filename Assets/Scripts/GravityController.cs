using UnityEngine;

public class GravityController : MonoBehaviour {
  // int interval = 1;
  // float nextTime = 0;
  float strength = 9.8f;

  // void Update () {
  //   if (Time.time >= nextTime) {
  //     Physics.gravity = new Vector3(-gameObject.transform.up.x, -gameObject.transform.up.y, -gameObject.transform.up.z) * strength;
  //       // Debug.Log("Gravity is now:" + Physics.gravity.ToString());
  //     nextTime += interval;
  //   }
  // }
  void Update() {
    Physics.gravity = new Vector3(-gameObject.transform.up.x, -gameObject.transform.up.y, -gameObject.transform.up.z) * strength;
        // Debug.Log("Gravity is now:" + Physics.gravity.ToString());
  }
}
