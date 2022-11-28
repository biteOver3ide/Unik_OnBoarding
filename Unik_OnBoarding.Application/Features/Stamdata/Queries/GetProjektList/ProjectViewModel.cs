using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_OnBoarding.Application.DTO.Kunde;
using Unik_OnBoarding.Application.DTO.Projekt;

namespace Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList
{
    public class ProjectViewModel
    {
        public ProjektDto ProjectDto { get; set; }
        public KundeDto KundeDto { get; set; }
    }
}
