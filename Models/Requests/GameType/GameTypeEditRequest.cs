﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Requests
{
    public class GameTypeEditRequest
    {
        public Guid GameId { get; set; }
        public string GameName { get; set; }
    }
}
