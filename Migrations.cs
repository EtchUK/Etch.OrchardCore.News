using OrchardCore.ContentManagement.Metadata;
using OrchardCore.Data.Migration;
using OrchardCore.Indexing;
using OrchardCore.Lucene;
using OrchardCore.Queries;
using OrchardCore.Recipes.Services;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Etch.OrchardCore.News
{
    public class Migrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;
        private readonly IRecipeMigrator _recipeMigrator;
        private readonly IQueryManager _queryManager;

        public Migrations(IContentDefinitionManager contentDefinitionManager, IRecipeMigrator recipeMigrator, IQueryManager queryManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
            _recipeMigrator = recipeMigrator;
            _queryManager = queryManager;
        }

        public async Task<int> CreateAsync()
        {
            await _recipeMigrator.ExecuteAsync("create.recipe.json", this);

            return 1;
        }

        public int UpdateFrom1()
        {
            _contentDefinitionManager.AlterPartDefinition("NewsPost", builder => builder
                .WithField("Tags", field => field
                    .WithSettings(new ContentIndexSettings
                    {
                        Included = true,
                        Stored = true
                    })));

            return 2;
        }

        public async Task<int> UpdateFrom2()
        {
            await _queryManager.SaveQueryAsync("ContentByTags", new LuceneQuery
            {
                Index = "News",
                ReturnContentItems = true,
                Name = "ContentByTags",
                Template = "{\r\n  \"query\": {\r\n    \"bool\": { \r\n      \"must\": [\r\n        { \"term\": { \"NewsPost.Tags\": \"{{tagId}}\" } }\r\n      ]\r\n    }\r\n  }\r\n}"
            });

            return 3;
        }
    }
}
