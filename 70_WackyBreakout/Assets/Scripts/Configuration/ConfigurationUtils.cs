﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Properties
    
    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return 7; }
    }

    /// <summary>
    /// Gets the ball impulse force
    /// </summary>
    /// <value>ball impulse force</value>
    public static float BallImpulseForce
    {
        get { return 8; }
    }

    public static float ballDeathTimer
    {
        get { return 10; }
    }

    public static float ballStartTimer
    {
        get { return 1; }
    }
    public static float ballMaxSpawnTimer
    {
        get { return 10; }
    }
    public static float ballMinSpawnTimer
    {
        get { return 5; }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {

    }
}
