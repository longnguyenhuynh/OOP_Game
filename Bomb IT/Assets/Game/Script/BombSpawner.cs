using UnityEngine;
using UnityEngine.Tilemaps;
public class BombSpawner : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject bombPrefab;
    public GameObject player = null;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector3Int cell = tilemap.WorldToCell(worldPos);
        //    Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

        //    Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (player == null)
        //        player = GameObject.Find("Player");

        //    Vector3 worldPos = Camera.main.ScreenToWorldPoint(player.transform.position);
        //    Vector3Int cell = tilemap.WorldToCell(worldPos);
        //    Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

        //    Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        //}
    }
}
