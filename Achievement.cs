using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16___2
{
    internal class Achievement
    {
        string AchievementName;
        string Description;
        int Goal;
        int progress = 0;
        bool IsCompleted = false;

        //static
        static int TotalAchievements;
        static int CompletedAchievements;


        public Achievement(string name, string description,int goal )
        {
            this.AchievementName = name;
            this.Description = description;
            this.Goal = goal;

            TotalAchievements++;
        }

        //목표 수치에 도달했는지
        public void AddProgress(int value)
        {
            progress += value; 
            if(progress >= Goal)
            {
                IsCompleted = true;
                CompletedAchievements++;
                Console.WriteLine($"업적 [{AchievementName}] 달성!");
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine("업적 이름 : " + AchievementName);
            Console.WriteLine("업적 설명 : " + Description);
            Console.WriteLine("목표 : " + Goal);
            Console.WriteLine("진행 상황 : " + progress);
            Console.WriteLine("달성 : " + IsCompleted);

        }
        static public void DisplaySummary()
        {
            Console.WriteLine("현재 생성된 업적 총 개수 : "+ TotalAchievements);
            Console.WriteLine("달성된 업적의 총 개수 : "+ CompletedAchievements);

        }




    }
}
