using UnityEngine;

public class UI : MonoBehaviour {
  GameObject _exitText;
  float _exitDuration = 3f;
  float _timeTilQuit;

  void OnEnable() {
    _exitText = Utils.Find("ExitText");
    _exitText.SetActive(false);
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.Escape)) {
      // When escape is first pressed.
      _timeTilQuit = _exitDuration;
    } else if (Input.GetKey(KeyCode.Escape)) {
      _timeTilQuit -= Time.deltaTime;

      // If countdown reached 0, exit the game.
      if (_timeTilQuit <= 0) {
        Application.Quit();
      }

      // If escape is still held.
      _exitText.GetComponent<TMPro.TMP_Text>().text = "Exiting in " + Mathf.Ceil(_timeTilQuit).ToString() + "...";
      _exitText.SetActive(true);
    } else {
      // If escape is no longer held.
      _exitText.SetActive(false);
    }
  }
}
