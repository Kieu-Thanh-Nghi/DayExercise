using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCtrler : AloneState
{
    bool _BlockInput;
    // Update is called once per frame
    void Update()
    {
        _BlockInput = inputs.BlockInput();
        animHandle.PlayBlock(_BlockInput);
        if (!_BlockInput) this.enabled = false;
    }
}
