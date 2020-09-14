using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Maps;

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
    
    protected void Awake()
    {
        Service = gameObject.GetComponent<MapsService>();            
        Service.ApiKey = LocalEnvironments.APIKey;
    }
}
