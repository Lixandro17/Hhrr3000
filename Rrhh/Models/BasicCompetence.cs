﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrhh.Models
{
    public class BasicCompetence : Competence
    {
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
