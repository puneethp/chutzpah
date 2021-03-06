using System.Collections.Generic;

namespace Chutzpah
{
    /// <summary>
    /// Options for code coverage.
    /// </summary>
    public class CoverageOptions
    {
        public CoverageOptions()
        {
            IncludePatterns = new List<string>();
            ExcludePatterns = new List<string>();
        }

        /// <summary>
        /// Whether or not code coverage collection is enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// If specified, pattern of files to include in the instrumentation phase.
        /// </summary>
        public ICollection<string> IncludePatterns { get; set; }

        /// <summary>
        /// If specified, pattern of files to exclude from the instrumentation phase.
        /// </summary>
        public ICollection<string> ExcludePatterns { get; set; }
    }
}