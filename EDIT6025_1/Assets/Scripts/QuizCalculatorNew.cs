using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculatorNew : MonoBehaviour
{
    // Declare an array to hold the quiz grades and a variable to hold the average grade
    public int[] quizGrades;
    private float averageGrade;

    void Start()
    {
        // Initialize quiz grades with random values between 0 and 100 use for loop
        quizGrades = new int[10];
        for (int i = 0; i < quizGrades.Length; i++)
        {
            quizGrades[i] = Random.Range(0, 101);
        }

        // Calculate the sum of all grades using foreach loop
        float sum = 0;
        foreach (int grade in quizGrades)
        {
            sum += grade;
        }

        // Calculate the average grade
        averageGrade = sum / quizGrades.Length;

        // Log the average grade to the console
        Debug.Log("Average Grade: " + averageGrade);

        // Classify performance and log the letter grade to the console if and else if
        if (averageGrade >= 90)
        {
            Debug.Log("Letter Grade: A");
        }
        else if (averageGrade >= 80)
        {
            Debug.Log("Letter Grade: B");
        }
        else if (averageGrade >= 70)
        {
            Debug.Log("Letter Grade: C");
        }
        else if (averageGrade >= 60)
        {
            Debug.Log("Letter Grade: D");
        }
        else
        {
            Debug.Log("Letter Grade: F");
        }
    }
}
