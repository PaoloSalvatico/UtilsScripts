using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class SaveManager
{
    public static string directory = Application.persistentDataPath + "/SaveData/";
    public static string filename = "DataContainer.txt";


    public static void Save(DataContainer dc)
    {

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        else
        {
            string json = JsonUtility.ToJson(dc, true);
            File.WriteAllText(directory + filename, json);
        }
    }
    public static DataContainer LoadData()
    {
        string fullPath = directory + filename;

        DataContainer dc = new DataContainer();

        if (File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);

            dc = JsonUtility.FromJson<DataContainer>(json);
        }
        else
        {

        }

        return dc;
    }



}