﻿using System;

namespace DemoSapientia.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}