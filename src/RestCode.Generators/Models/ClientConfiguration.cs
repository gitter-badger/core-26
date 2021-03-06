﻿namespace RestCode.Generators.Models
{
    public class ClientConfiguration
    {
        public string MetadataEndpoint { get; set; }
        public string Method { get; set; } = "OPTIONS";
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Suffix { get; set; }
        public string GeneratorType { get; set; }
        public string GeneratorAssembly { get; set; }
    }
    
}
