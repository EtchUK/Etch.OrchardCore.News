using OrchardCore.Modules.Manifest;

[assembly: Module(
    Author = "Etch UK.",
    Category = "Content",
    Description = "Configures content definitions for news.",
    Name = "News",
    Version = "$(VersionNumber)",
    Website = "https://etchuk.com",
    Dependencies = new string[] {
        "Etch.OrchardCore.SEO",
        "OrchardCore.ContentFields",
        "OrchardCore.Flows",
        "OrchardCore.Lucene",
        "OrchardCore.Media",
        "OrchardCore.PublishLater",
        "OrchardCore.Queries",
        "OrchardCore.Taxonomies"
    }
)]