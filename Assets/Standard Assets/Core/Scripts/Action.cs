﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerAction {
	
}
public interface IAction : ITriggerAction {
	void OnEvent();
}
