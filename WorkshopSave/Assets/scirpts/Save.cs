using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class Save
{
    public static void saveStats (Inventory Inventory)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string Path = Application.persistentDataPath + "/GameData.fun";
        FileStream stream = new FileStream(Path, FileMode.Create);

        InventoryData data = new InventoryData(Inventory);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static InventoryData loadInventory()
    {
        string path = Application.persistentDataPath + "/GameData.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            InventoryData data = formatter.Deserialize(stream) as InventoryData;
            stream.Close();
            return data;
        }else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}

/*public class Save : MonoBehaviour
{
    string saveFiles;

    public void Awake()
    {
        saveFiles = Application.persistentDataPath + "/gamedata.json";
    }


    public static void save()
    {
        //créer une variable de ou stocker votre save 
        //Application.PersistantPath
        //string path = Application.persistantPath +'/save.mysupersave';
        //BinaryFormetter qui permet de transformer une classe en binaire 

        //Stream
    }
    public static void load()
    {
        //vérifier que le fichier existe 
            
        //créer le path 
        //créer le binaryFormatter 
        //ouvrri le ficher, récupere le text et le cast => mySave 
        //return voitre variable cast en mySave
    }
}*/
