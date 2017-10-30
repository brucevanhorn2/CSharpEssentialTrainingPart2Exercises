using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            if( color.ToLower() == "blue")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
