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
    protected static Setting StaticInstance
    {
        private get
        {
            if(_StaticInstance == null) { throw new SettingInstanceNotSetException(); }
            return _StaticInstance;
        }
        set{ _StaticInstance = value; }
    }
    private static Setting _StaticInstance = null;
    protected Setting() {}
#endregion
}

/// <summary>
/// Settingクラスインスタンスが設定されていないときに投げられる例外
/// </summary>
public class SettingInstanceNotSetException : Exception
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public SettingInstanceNotSetException()
        : base("SettingクラスのStatincInstanceが設定されていません。")
    {   
    }
}
