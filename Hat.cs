using System;

namespace Quest
{
    class Hat
    {
        public static int ShininessLevel {get; set;}

        public static string ShininessDescription(string name)
        {
            string Name = name;
            string status = "still just a hat";
            if (ShininessLevel > 9)
            {
                status = "blinding";
            }
            else if (ShininessLevel < 9 && ShininessLevel > 6)
            {
                status = "bright";
            }
            else if (ShininessLevel < 5 && ShininessLevel > 2)
            {
                status = "noticeable";
            }
            else if (ShininessLevel < 2)
            {
                status = "dull";
            }

            return $"{Name}'s Hat is {status}";
        }
    }
}