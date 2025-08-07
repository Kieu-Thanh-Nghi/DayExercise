using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimName
{
    public const string Idle = "Idle";
    public const string Walk = "Walk";
    public const string Jump = "Jump";
    public const string Crouch = "Crouch";
    public const string RangeAttack = "RangeAttack";    
    public const string MeleAttack = "MeleAttack";
    public const string Strike = "Strike";    
    public const string Dash = "Dash";
    public const string JumpAttack = "JumpAtk";    
    public const string JumpSkill = "JumpSkill";    
    public const string CritAttack = "CritAttack";

    public static string CrouchAttack = "CrouchAttack";

    public static string Block = "Block";
    public static string SwordDidle = "SwordDidle";

    public static string JumpToFall = "JumptoFall";

    public static string Fall = "Fall";

    public static string Slide = "Slide";

    public static string DashAttack = "DashAttack";

    public static string PrePare = "Prepare";
    public static string Intro = "Intro";

    public static string MoveBack = "Move_Back";
    public static string MoveForward = "Move_Forward";

    public static string MoveUp = "Move_Up";
    public static string MoveDown = "Move_Down";

    public static class AnimParameter
    {
        public const string AtkTrigger = "AttackTrigger";
        public const string RangeAtkTrigger = "RangeAtkTrigger";

        public static string IsBlocking = "isBlocking";

        public static string FallTrigger = "FallTrigger";
    }
}
