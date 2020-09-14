using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 設定インタフェース
/// </summary>
public interface ISetting
{
    /// <summary>
    /// APIキー
    /// </summary>
    string APIKey { get; }
}

/// <summary>
/// 設定
/// </summary>
public class Setting
{

    /// <summary>
    /// APIキー
    /// </summary>
    public string APIKey { get { return Interface.APIKey; } }

#region Interface Access
    protected ISetting Interface
    {
        set { _Interface = value; }
        get
        {
            if(_Interface == null) { throw new SettingInterfaceNotSetException(); }
            return _Interface;
        }
    }
    private ISetting _Interface = null;
#endregion

#region Singleton
    public static Setting Instance { get { return _Instance; } }
    private static Setting _Instance = new Setting();
    protected Setting() {}
#endregion
}

/// <summary>
/// SettingクラスにISettingインタフェースが設定されていないときに投げられる例外
/// </summary>
public class SettingInterfaceNotSetException : Exception
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public SettingInterfaceNotSetException()
        : base("SettingクラスにISettingインタフェースが設定されていません。")
    {   
    }
}
