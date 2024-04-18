using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create objects of the sub-classes
        Trapezium trapezium = new Trapezium();
        Circle circle = new Circle();
        Nonagon nonagon = new Nonagon();

        // Call methods to demonstrate functionality
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();
        trapezium.CalculateUnknownSides();

        circle.CalculateArea();
        circle.CalculatePerimeter();
        circle.CalculateRadius();

        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        int sides = nonagon.CalculateNumberOfSides();
        Debug.Log("Number of sides in Nonagon: " + sides);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    public void CalculateUnknownSides()
    {
        // Calculate unknown sides
        Debug.Log("Calculating unknown sides of Trapezium");
    }

    public void CalculateArea()
    {
        // Calculate area of Trapezium
        Debug.Log("Calculating area of Trapezium");
    }

    public void CalculatePerimeter()
    {
        // Calculate perimeter of Trapezium
        Debug.Log("Calculating perimeter of Trapezium");
    }
}

public class Circle : IShape
{
    public void CalculateArea()
    {
        // Calculate area of Circle
        Debug.Log("Calculating area of Circle");
    }

    public void CalculatePerimeter()
    {
        // Calculate perimeter of Circle
        Debug.Log("Calculating perimeter of Circle");
    }

    public void CalculateRadius()
    {
        // Calculate radius of Circle
        Debug.Log("Calculating radius of Circle");
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;

    public void CalculateArea()
    {
        // Calculate area of Nonagon
        Debug.Log("Calculating area of Nonagon");
    }

    public void CalculatePerimeter()
    {
        // Calculate perimeter of Nonagon
        Debug.Log("Calculating perimeter of Nonagon");
    }

    public int CalculateNumberOfSides()
    {
        // Return number of sides in Nonagon
        return numberOfSides;
    }
}
