using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public static class InputManager {

    public static MainInput.PlayerActions Actions { get => Input.Player; }
    public static MainInput Input {
        get {
            if (_input == null) {
                _input = new MainInput();
                _input.Enable();
            }
            return _input;
        }
    }
    static MainInput _input;

}
