using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 設定
/// </summary>
public abstract class Setting
{
    /// <summary>
    /// APIキー
    /// </summary>
    public abstract string APIKey { get; }

#region Access
    public static Setting Instance { get { return StaticInstance; } }
    protected static Setting StaticInstance { private get; set; }
    protected Setting() {}
#endregion
}
