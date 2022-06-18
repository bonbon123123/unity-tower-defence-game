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
    public GameObject laserTurretPrefab;
    public GameObject missleTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
