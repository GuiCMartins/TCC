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
    private Transform player = null;

    public override void interaction()
    {
        changeScene();
    }

    private void changeScene()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            System.Console.Write("Standard DateTime Format Specifiers");
            this.player.position = this.targetPlace.position;
            this.confiner.m_BoundingShape2D = this.bounding;
            this.virtualCamera.m_Lens.OrthographicSize = (float) this.sizeCamera;
        }
    }
}
