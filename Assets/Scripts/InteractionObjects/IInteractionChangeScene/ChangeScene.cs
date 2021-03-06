using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class ChangeScene : Interaction
{
    //Serialized fields
    [Header("Confiner configuration")]
    [SerializeField]
    private CinemachineConfiner confiner = null;
    [Header("Bounding configuration")]
    [SerializeField]
    private PolygonCollider2D bounding = null;
    [Header("Virtual camera configuration")]
    [SerializeField]
    private CinemachineVirtualCamera virtualCamera = null;
    [SerializeField]
    private double sizeCamera = 0.0;
    [Header("Target Scene configuration")]
    [SerializeField]
    private Transform targetPlace = null;
    [Header("Player configuration")]
    [SerializeField]
    private GameObject player = null;
    [SerializeField]
    private double sizePlayerX = 0.0;
    [SerializeField]
    private double sizePlayerY = 0.0;

    //Non serialized fields
    private GameObject gameController = null;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindWithTag("GameController");
    }

    public override void interaction()
    {
        changeScene();
    }

    private void changeScene()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            System.Console.Write("Standard DateTime Format Specifiers");
            this.gameController.GetComponent<GameController>().setCheckPoint(this.targetPlace);
            this.player.transform.position = this.targetPlace.position;
            flip();
            this.confiner.m_BoundingShape2D = this.bounding;
            this.virtualCamera.m_Lens.OrthographicSize = (float) this.sizeCamera;
        }
    }

    private void flip()
    {
        if (this.player.GetComponent<Movement>().getIsLeft())
        {
            this.player.transform.localScale = new Vector3((float) -this.sizePlayerX, (float)this.sizePlayerY, 0);
        }
        else
        {
            this.player.transform.localScale = new Vector3((float)this.sizePlayerX, (float)this.sizePlayerY, 0);
        }
    }
}
