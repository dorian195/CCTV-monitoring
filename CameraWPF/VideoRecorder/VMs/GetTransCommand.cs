﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTVSystem.Client.ViewModels
{
    class GetTransCommand
    {
        public string Filename { get; set; }
        public DateTime RecordingDate { get; set; }
        public int Hours { get; set; }

        public int Minutes { get; set; }
        public Camera Camera { get; set; }

    }
   // class CamId
   // {
    //    public string id { get; set; }
   // }
}
