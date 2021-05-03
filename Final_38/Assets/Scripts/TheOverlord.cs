using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TheOverlord
{
    private static int level1 = 0;
    private static int level2 = 0;
    private static int level3 = 0;
    
    private static string last = "Level 1";
   public static bool Win
        {
            get
            {
                if((level1+level2+level3)>=3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static int Level1
        {
            get
            {
                return level1;
            }
            
            set
            {
                level1 = value;
            }
        }

        public static int Level2
        {
            get
            {
                return level2;
            }

            set
            {
                level2 = value;
            }
        }

        public static int Level3
        {
            get
            {
                return level3;
            }

            set
            {
                level3 = value;
            }
        }

        public static string LastScene
        {
            get
            {
                return last;
            }

            set
            {
                last = value;
            }
        }
    }

