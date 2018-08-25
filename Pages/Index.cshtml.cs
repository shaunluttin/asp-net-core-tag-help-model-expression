using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_tag_help_model_expression.Pages
{
    public class Whatever {
        public string Name { get; set; }
        public bool IsOrganic { get; set; }

        public Whatever(string name, bool isOrganic)
        {
            Name = name;
            IsOrganic = isOrganic;
        }
    }

    public class IndexModel : PageModel
    {
        public List<Whatever> Foods { get; set;} = new List<Whatever> {
            new Whatever("carrot", true),
            new Whatever("grape", true),
        };

        public void OnGet()
        {
        }
    }
}
