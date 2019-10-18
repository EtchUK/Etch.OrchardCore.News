using OrchardCore.Modules.Manifest;

[assembly: Module(
    Author = "Etch UK.",
    Category = "Content",
    Description = "Configures content definitions for news.",
    Name = "News",
    Version = "0.1.1",
    Website = "https://etchuk.com",
    Dependencies = new string[] {
        "Etch.OrchardCore.Blocks.EditorJS",
        "OrchardCore.ContentFields",
        "OrchardCore.Media",
        "OrchardCore.Taxonomies"
    }
)]