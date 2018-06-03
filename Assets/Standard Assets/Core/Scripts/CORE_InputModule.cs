using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CORE_InputModule : StandaloneInputModule {

    public override void Process() {
        base.Process();
        
        if (this.UseFakeInput())
        {
            this.ProcessPointer();
        }
        else
        {
            this.ProcessTouchEvents();
        }
    }
    /// <summary>
    ///   Process all touch events.
    /// </summary>
    private void ProcessTouchEvents()
    {
        // for (var i = 0; i < Input.touchCount; ++i)
        // {
        //     var input = Input.GetTouch(i);

        //     bool released;
        //     bool pressed;
        //     var pointer = this.GetTouchPointerEventData(input, out pressed, out released);
        // }
    }
    /// <summary>
    ///   For debugging touch-based devices using the mouse.
    /// </summary>
    private void ProcessPointer()
    {
        var pointerData = this.GetMousePointerEventData(0);

        var leftPressData = pointerData.GetButtonState(PointerEventData.InputButton.Left).eventData;

        // fake touches... on press clear delta
        if (leftPressData.PressedThisFrame())
        {
            var pointerEvent = leftPressData.buttonData;
            var current = pointerEvent.pointerCurrentRaycast.gameObject;
            // print(current);
        //     leftPressData.buttonData.delta = Vector2.zero;

        //     this.OnPressed(leftPressData.buttonData.pointerId);
        }

        // this.ProcessPress(
        //     leftPressData.buttonData,
        //     leftPressData.PressedThisFrame(),
        //     leftPressData.ReleasedThisFrame());

        // // only process move if we are pressed...
        // if (Input.GetMouseButton(0))
        // {
        //     this.ProcessMove(leftPressData.buttonData);
        //     this.ProcessDragDrop(leftPressData.buttonData);
        //     this.ProcessDrag(leftPressData.buttonData);
        // }
    }
    private bool UseFakeInput()
    {
        return !Input.touchSupported;
    }
}
