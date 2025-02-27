﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Industry
{
    class Write
    {
        private ConsoleColor _defColour = Console.ForegroundColor;
        private ConsoleColor _cityColour = ConsoleColor.Cyan;

        public void HandleProductSold(Facility sender, EventArgs args)
        {
            Console.Write("City: ");
            Console.ForegroundColor = _cityColour;
            Console.Write(sender.Name);
            Console.ForegroundColor = _defColour;
            Console.Write(" consumes products. \n");
        }
    }
}
