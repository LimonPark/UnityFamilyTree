using UnityEngine;
using System.IO;

public class FamilyTreeManager : MonoBehaviour
{
    public GameObject personPrefab;
    public FamilyTreeWrapper familyTree;
    void Start()
    {
        string path = Path.Combine(Application.persistentDataPath, "/Users/nikitakafes/Desktop/FamilyTreeXR/Assets/StreamingAssets/familyTree.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            familyTree = JsonUtility.FromJson<FamilyTreeWrapper>(json);
            Debug.Log("Загружено " + familyTree.people.Count + " членов семьи.");
        }
        else
        {
            Debug.Log("Файл не найден: " + path);
        }
    }
}
