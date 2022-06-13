using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 turretOffset;


    private GameObject turret;
    private Renderer rend;
    private Color startColor;



    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
     void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("turret is here");
            return;
        }
        GameObject turretToBuild=BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + turretOffset, transform.rotation);

    }


}
