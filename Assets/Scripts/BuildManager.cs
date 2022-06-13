using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("too many build managers");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }
    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
