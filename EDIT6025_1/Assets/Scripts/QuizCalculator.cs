using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    // create float variables for our quizes

    // Array to hold quiz grades
    public float [] quizGrades = new float[5];
    public float averageGrade;
  
    void Start()
    {
        // Assign random grades to each quiz using a for loop
        for (int i = 0; i < quizGrades.Length; i++) 
        {
            quizGrades[i] = Random.Range(0f, 100f);
        }

        // calculate the average grade using a foreach loop
        float total = 0;
        foreach (float grade in quizGrades)
        {
            total += grade;
        }
        averageGrade = total / quizGrades.Length;

        // Output the average grade
        Debug.Log("Average Quiz Grade: " + averageGrade);

        //Determine the letter grade using if statements
        if (averageGrade >= 90 & averageGrade <= 100)
        {
            Debug.Log("Grade A");
        }
        else if (averageGrade >= 80 & averageGrade < 90)
        {
            Debug.Log("Grade B");
        }
        else if (averageGrade >= 70 & averageGrade < 80)
        {
            Debug.Log("Grade C");
        }
        else
        {
            Debug.Log("Grade F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
