using UnityEngine;

public class DropOff : MonoBehaviour {
  GameObject _passengers;

  void OnEnable() {
    _passengers = Utils.Find("Passengers");
  }

  // Player should only have one "passenger" at a time, so just disable any passengers.
  void OnTriggerEnter() {
    foreach (Transform child in _passengers.transform) {
      child.gameObject.SetActive(false);
    }

    // Play the sound of them getting out of the car.
    _passengers.GetComponent<AudioSource>().Play();
  }
}
