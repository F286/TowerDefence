using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public static class Core {
	public static Vector2 ToWorld(this Vector2 screenPosition) {
    return Camera.main.ScreenToWorldPoint(screenPosition);
	}
	public static Vector2 ToScreen(this Vector2 worldPosition) {
    return Camera.main.WorldToScreenPoint(worldPosition);
	}
	public static Vector2 ToWorld(this PointerEventData eventData) {
    return Camera.main.ScreenToWorldPoint(eventData.position);
	}
	public static Vector2 ToScreen(this PointerEventData eventData) {
    return Camera.main.WorldToScreenPoint(eventData.position);
	}
	public static Vector2 CenterOfMass(this Component transform) {
		return transform.GetComponent<Rigidbody2D>().worldCenterOfMass;
	}

	public static Vector2 SnapToGrid(this Vector2 vector) {
		return new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
	}

  public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single) {
    var isLoaded = false;
    for (int i = 0; i < SceneManager.sceneCount; i++) {
      var item = SceneManager.GetSceneAt(i);

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
    for (int i = 0; i < SceneManager.sceneCount; i++) {
      var item = SceneManager.GetSceneAt(i);
      
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
