using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GeneralSaveManager : MonoBehaviour
{
    private static string path;

    private static void Init()
    {
#if UNITY_ANDROID
            path = Path.Combine(Application.persistentDataPath, "data.json");
#else
        path = Path.Combine(Application.dataPath, "data.json");
#endif
    }

    /// <summary>
    /// Salva in un Json l'oggetto passato come parametro
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    public static void SerializeData<T>(T data) where T : class
    {
        if (path == null) Init();

        string jsonDataString = JsonUtility.ToJson(data, true);

        File.WriteAllText(path, jsonDataString);
    }

    /// <summary>
    /// Legge da un json
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T DeserializeData<T>() where T : class
    {
        if (path == null) Init();

        if (!File.Exists(path))
        {
            File.Create(path).Dispose();
            return null;
        }

        string loadedJsonDataString = File.ReadAllText(path);

        return JsonUtility.FromJson<T>(loadedJsonDataString);
    }

    /// <summary>
    /// Deserializza un testo nell oggetto del tipo passato
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="text"></param>
    /// <returns></returns>
    public static T DeserializeData<T>(string text) where T : class => JsonUtility.FromJson<T>(text);
}


