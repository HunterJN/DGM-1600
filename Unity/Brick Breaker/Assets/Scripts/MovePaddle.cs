using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

    public float verticalOffset;

    void Update  () {
        //get current paddle position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);
        //get mouse position
        //convert mouse position to world space
        float mousePositionX = Input.mousePosition.x / Screen.width * 24 - 12;
        //float mousePositionX = Input.mousePosition.x / Screen.width - 12 * 24;
        //save position
        paddlePosition.x = mousePositionX;
        //set this paddle object to saved position
        gameObject.transform.position = paddlePosition;
    }
}
