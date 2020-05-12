﻿using System;
using System.Collections.Generic;

namespace Microsoft.Tye.Hosting.Model
{
    public class HttpProber
    {
        public string Path { get; set; } = default!;
        public int? Port { get; set; }
        public string? Protocol { get; set; }
        public List<KeyValuePair<string, object>> Headers { get; set; } = new List<KeyValuePair<string, object>>();
    }
}