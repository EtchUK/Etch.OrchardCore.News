using OrchardCore.Modules.Manifest;

[assembly: Module(
    Author = "Etch UK.",
    Category = "Content",
    Description = "Configures content definitions for news.",
    Name = "News",
    Version = "0.2.0",
    Website = "https://etchuk.com",
    Dependencies = new string[] {
        "Etch.OrchardCore.Blocks",
        "OrchardCore.ContentFields",
        "OrchardCore.Media",
        "OrchardCore.Taxonomies"
    }
)]