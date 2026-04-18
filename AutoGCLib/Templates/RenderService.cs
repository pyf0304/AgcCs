using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scriban;

namespace AutoGCLib
{

    public class RenderService
    {
        public string Render(string templateText, object model)
        {
            var template = Template.Parse(templateText);
            return template.Render(model);
        }
    }
}
