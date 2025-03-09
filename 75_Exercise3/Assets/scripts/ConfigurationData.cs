using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data with default values
    static float teddyBearMoveUnitsPerSecond;
    static float cooldownSeconds;

    #endregion

    #region Properties

    public float TeddyBearMoveUnitsPerSecond
    {
        get { return teddyBearMoveUnitsPerSecond; }
    }

    public float CooldownSeconds
    {
        get { return cooldownSeconds; }
    }

    public ConfigurationData()
    {
        StreamReader input = null;
        try
        {
            string path = Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName);
            input = new StreamReader(path);
            // Read the header row
            string headerRow = input.ReadLine();
            string csvValues = input.ReadLine();
            SetConfigurationDataFields(headerRow, csvValues);
        }
        catch (Exception ex)
        {
            Debug.LogError("Error reading configuration file: " + ex.Message);
        }
        finally
        {
            if (input != null)
            {
                input.Close();
            }
        }
    }

    static void SetConfigurationDataFields(string headerRow, string csvValues)
    {
        // split the header and csv values
        string[] headers = headerRow.Split(',');
        string[] values = csvValues.Split(',');
        // dynamically set the configuration data fields
        for (int i = 0; i < headers.Length; i++)
        {
            switch (headers[i])
            {
                case "teddyBearMoveUnitsPerSecond":
                    float.TryParse(values[i], out teddyBearMoveUnitsPerSecond);
                    break;
                case "cooldownSeconds":
                    float.TryParse(values[i], out cooldownSeconds);
                    break;
            }
        }
    }

    #endregion
}
