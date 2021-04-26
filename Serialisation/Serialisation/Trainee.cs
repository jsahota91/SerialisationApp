﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    [Serializable]
    public class Trainee
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int SpartaNo { get; init; }
        [JsonIgnore]
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{SpartaNo} - {FullName}";
        }
    }
}
