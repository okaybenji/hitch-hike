using UnityEngine;

public class GravityController : MonoBehaviour {
  GameObject _planet;

  float strength = 9.8f;

  void OnEnable() {
    _planet = Utils.Find("Planet");
  }

  void Update() {
    Vector3 vectorTowardPlanet = _planet.transform.position - gameObject.transform.position;
    Physics.gravity = Vector3.Normalize(vectorTowardPlanet) * strength;
    // Debug.Log("Gravity is now:" + Physics.gravity.ToString());
  }
}
