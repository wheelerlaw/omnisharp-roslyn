﻿using System.Collections.Generic;
using System.Linq;

namespace OmniSharp.Razor.Models
{
    public class RazorProjectInformation
    {
        public RazorProjectInformation(/*ProjectEntry entry,*/ bool includeSourceFiles = false)
        {
            /*this.Path = entry.ProjectDirectory;

            var baseContext = entry.ProjectStates.FirstOrDefault()?.ProjectContext;
            this.Name = baseContext?.ProjectFile?.Name;
            this.Frameworks = entry.ProjectStates
                .Select(state => new RazorFramework(state.ProjectContext.TargetFramework))
                .ToList();
            this.ProjectSearchPaths = baseContext?.GlobalSettings?.ProjectSearchPaths ?? new List<string>();
            this.Configurations = baseContext?.RootProject?.Project?.GetConfigurations()
                ?.Select(x => new RazorConfiguration(baseContext, x))
                ?.ToList() ?? new List<RazorConfiguration>();

            var sourceFiles = new List<string>();
            if (includeSourceFiles)
            {
                sourceFiles.AddRange(entry.ProjectStates
                    .SelectMany(x => x.ProjectContext.ProjectFile.Files.SourceFiles)
                    .Distinct());
            }

            this.SourceFiles = sourceFiles;*/
        }

        public string Path { get; }
        public string Name { get; }
        public IEnumerable<string> ProjectSearchPaths { get; set; }
        public IEnumerable<RazorConfiguration> Configurations { get; set; }
        public IEnumerable<RazorFramework> Frameworks { get; set; }
        public IEnumerable<string> SourceFiles { get; set; }
    }
}