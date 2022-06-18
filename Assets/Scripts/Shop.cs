using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseMissleTurret()
    {
        buildManager.SetTurretToBuild(buildManager.missleTurretPrefab);
    }
    public void PurchaseLaserTurret()
    {
        buildManager.SetTurretToBuild(buildManager.laserTurretPrefab);
    }


}
