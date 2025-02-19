﻿using AccountingSystemForTheNursery.Models.Commands;

namespace AccountingSystemForTheNursery.Models.Requests
{
    public class UpdateAnimalRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // public string AnimalClass { get; set; }

        public string Commands { get; set; }

        public DateTime Birthday { get; set; }

        public string Type { get; set; }
    }
}
