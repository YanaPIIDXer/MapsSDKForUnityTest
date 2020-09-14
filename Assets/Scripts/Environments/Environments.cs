using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 環境
/// </summary>
public abstract class Environments
{
    /// <summary>
    /// APIキー
    /// </summary>
    public abstract string APIKey { get; }

#region Access
    public static Environments Instance { get { return StaticInstance; } }
    protected static Environments StaticInstance
    {
        private get
        {
            if(_StaticInstance == null) { throw new EnvironmentsInstanceNotSetException(); }
            return _StaticInstance;
        }
        set{ _StaticInstance = value; }
    }
    private static Environments _StaticInstance = null;
    protected Environments() {}
#endregion
}

/// <summary>
/// Environmentsクラスインスタンスが設定されていないときに投げられる例外
/// </summary>
public class EnvironmentsInstanceNotSetException : Exception
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EnvironmentsInstanceNotSetException()
        : base("EnvironmentsクラスのStatincInstanceが設定されていません。")
    {   
    }
}
