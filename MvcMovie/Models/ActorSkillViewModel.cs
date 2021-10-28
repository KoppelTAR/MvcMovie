using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ActorSkillViewModel
    {
        public List<Actors> actors { get; set; }
        public SelectList skills { get; set; }
        public string skill { get; set; }
        public string SearchString { get; set; }
    }
}
