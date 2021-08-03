using UnityEngine;

public class Billboard : MonoBehaviour {
  Camera _camera;

  void OnEnable() {
    _camera = Utils.Find("Main Camera").GetComponent<Camera>();
  }

  void LateUpdate() {
    transform.LookAt(_camera.transform);
  }
}
