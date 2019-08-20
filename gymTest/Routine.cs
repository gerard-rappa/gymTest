using System.Collections.Generic;

namespace gymTest
{
    public class Routine
    {
        Category day;
        List<Exercise> exercises;

        public Routine()
        {

        }
    }

    public class Category
    {
        //leg day, cardio day, etc.
        string category;

        public Category(string day)
        {
            this.category = day;
        }
    }

    public class Exercise
    {
        //the actual exercise - run, squats, pullups etc.
        string exercise;
        Attributes info;
    }

    public class Attributes
    {
        //attributes of exercise-Do not need all of these every time
        //set bools to true when in use
        bool isTime = false;
        bool isDistance = false;
        bool isWeight = false;
        bool isSets = false;
        bool isReps = false;

        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        enum distance { m, km, mi, yds };
        float distanceValue = 0;
        enum weight { kg, lbs };
        float weightValue = 0;
        int sets = 0;
        int reps = 0;
    }
}