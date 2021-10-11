using OrchardCore.Modules.Manifest;

[assembly: Module(
    Author = "Etch UK.",
    Category = "Content",
    Description = "Configures content definitions for news.",
    Name = "News",
    Version = "1.1.0",
    Website = "https://etchuk.com",
    Dependencies = new string[] {
        "Etch.OrchardCore.SEO",
        "OrchardCore.ContentFields",
        "OrchardCore.Flows",
        "OrchardCore.Lucene",
        "OrchardCore.Media",
        "OrchardCore.Queries",
        "OrchardCore.Taxonomies"
    }
)]