﻿using System.Collections.Generic;

namespace SofTracerAPI.Commands.Projects.Requirements
{
    public class CreateRequirementsCommand
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }

        public int ParentId { get; set; }

        public List<CreateRequirementsCommand> Children { get; set; }
    }
}