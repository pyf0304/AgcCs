using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGCLib
{
    public class TemplateService
    {
        private readonly string _basePath;

        public TemplateService()
        {
            _basePath = Path.Combine(AppContext.BaseDirectory, "Templates");
        }

        public string GetTemplate(string path)
        {
            var fullPath = Path.Combine(_basePath, path);
            return File.ReadAllText(fullPath, Encoding.UTF8);
        }
    }
}
