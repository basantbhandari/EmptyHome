using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class pathscript : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public EdgeCollider2D egdeCol;

    List<Vector2> points;


    public void UpdateLine(Vector2 mousePos) {

        if (points == null) {

            points = new List<Vector2>();
            SetPoint(mousePos);
            return;
        }

        //checking if the mouse has moved enough for us to insert new point
        //if it has: Insert point at mouse position

        if (Vector2.Distance(points.Last(), mousePos)  > .1f) {

            SetPoint(mousePos);

        }


   

    }


    void SetPoint(Vector2 point) {

        points.Add(point);

        lineRenderer.numPositions = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);

        if (points.Count > 1) {
            egdeCol.points = points.ToArray();
  
        }



    }





    // Update is called once per frame
    void Update() {

        
    }
}
