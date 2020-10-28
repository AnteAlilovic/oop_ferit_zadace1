using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1

{
    public class Episode
    {
        public int viewers;
        public double scoreSum { get; set; }
        public double score { get; set; }

        public Episode()
        {
            viewers = 0;
            scoreSum = 0;
            score = 0;
        }
        public Episode(int aViewers, double aScoreSum, double aScore)
        {
            viewers = aViewers;
            scoreSum = aScoreSum;
            score = aScore;
        }
        public void AddView(double RandScore)
        {
            viewers += 1;
            scoreSum += RandScore;
            if (RandScore > score)
            {
                score = RandScore;
            }
        }
        public double GetMaxScore()
        {
            return score;
        }
        public int GetViewerCount()
        {
            return viewers;
        }
        public double GetAverageScore()
        {
            double rez;
            rez = scoreSum / viewers;
            return rez;
        }
    }
}