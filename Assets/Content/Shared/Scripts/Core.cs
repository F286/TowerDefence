using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Core {

	public static Vector2 centerOfMass(this Component transform) {
		return transform.GetComponent<Rigidbody2D>().worldCenterOfMass;
	}

  public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single) {
    var isLoaded = false;
    foreach (var item in SceneManager.GetAllScenes()) {
      if (item.name == sceneName) {
        isLoaded = true;
        break;
      }
    }
    if (!isLoaded) {
      SceneManager.LoadScene(sceneName, mode);
    }
  }

  public static Scene GetScene(string sceneName) {
    foreach (var item in SceneManager.GetAllScenes()) {
      if (item.name == sceneName) {
        return item;
      }
    }
		throw new Exception("Could not get scene with name: " + sceneName);
  }

	public static void SendGlobalEvent(string eventName, UnityEngine.Object context = null) {
    Debug.LogWarning("Send Global Event: <b>" + eventName + "</b>", context);
    foreach (var item in GameObject.FindObjectsOfType<TRIGGER_GlobalEvent>()) {
      if (item.eventName == eventName) {
        item.OnEvent();
      }
    }
  }
}
