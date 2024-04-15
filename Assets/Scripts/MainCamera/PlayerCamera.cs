using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Mario.Camera
{
    public class PlayerCamera : MonoBehaviour
    {
        GameObject player;
        [SerializeField] float currentValue;
        [SerializeField] float minX;
        [SerializeField] float maxX;
        [SerializeField] float minY;
        [SerializeField] float maxY;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        void Update()
        {
            float x = Mathf.Clamp(player.transform.position.x, minX, maxX);
            float y = Mathf.Clamp(player.transform.position.y, minY, maxY);
            gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
        }
    }


}
