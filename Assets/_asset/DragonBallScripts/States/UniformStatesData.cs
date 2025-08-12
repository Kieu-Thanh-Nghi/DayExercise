using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformStatesData : MonoBehaviour
{
    public SpriteRenderer _spriteRenderer;
    public InputControl _inputs;
    public CharController _charController;
    public MoveControl _moveControl;
    public StatesName currentState = StatesName.NoState;
}
