using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Maps;
using Google.Maps.Coord;
using Google.Maps.Examples.Shared;

/// <summary>
/// マップ生成Component
/// </summary>
[RequireComponent(typeof(MapsService))]
public class MapGenerator : MonoBehaviour
{
    /// <summary>
    /// MapsService
    /// </summary>
    private MapsService Service = null;
    
    /// 緯度
    /// </summary>
    [SerializeField]
    private float Lat = 35.698683f;

    /// <summary>
    /// 経度
    /// </summary>
    [SerializeField]
    private float Lng = 139.77421900000002f;

    protected void Awake()
    {
        Service = GetComponent<MapsService>();            
        Service.ApiKey = LocalEnvironments.APIKey;
        // この辺はStartメソッドでやらないと駄目らしい。
        //Service.InitFloatingOrigin(new LatLng(Lat, Lng));
        //Service.LoadMap(DefaultBounds, DefaultGameObjectOptions);
    }

    protected void Start()
    {
        Service.InitFloatingOrigin(new LatLng(Lat, Lng));
        // ↓Exampleは使いたくなかったが、GameObjectOptionsの構築が面倒だったので止む無く失敬。
        Service.LoadMap(ExampleDefaults.DefaultBounds, ExampleDefaults.DefaultGameObjectOptions);
    }
}
