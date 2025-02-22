﻿using CommandLine;

namespace CodeCoverageSummary
{
    public class CommandLineOptions
    {
        [Value(index: 0, Required = true, HelpText = "Code coverage file to analyse.")]
        public string Filename { get; set; }

        [Option(longName: "badge", Required = false, HelpText = "Include a badge reporting the Line Rate coverage in the output using shields.io - true or false.", Default = false)]
        public bool Badge { get; set; }

        [Option(longName: "format", Required = false, HelpText = "Output Format - markdown or text.", Default = "text")]
        public string Format { get; set; }

        [Option(longName: "output", Required = false, HelpText = "Output Type - console, file or both.", Default = "console")]
        public string Output { get; set; }
    }
}
