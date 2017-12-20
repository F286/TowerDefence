using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ACTION_LoadScene : MonoBehaviour, IAction {
	public string sceneName = "";
	public LoadSceneMode mode;
	
	public void OnEvent() {
		Core.LoadScene(sceneName, mode);
	}
}
