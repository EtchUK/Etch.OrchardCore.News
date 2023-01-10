using OrchardCore.ContentManagement.Metadata;
using OrchardCore.Data.Migration;
using OrchardCore.Indexing;
using OrchardCore.Recipes.Services;
using OrchardCore.Search.Elasticsearch.Core.Models;
using OrchardCore.Search.Lucene.Model;
using System.Threading.Tasks;

namespace Etch.OrchardCore.News
{
    public class Migrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;
        private readonly IRecipeMigrator _recipeMigrator;

        public Migrations(IContentDefinitionManager contentDefinitionManager, IRecipeMigrator recipeMigrator)
        {
            _contentDefinitionManager = contentDefinitionManager;
            _recipeMigrator = recipeMigrator;
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
                    .WithSettings(new LuceneContentIndexSettings
                    {
                        Included = true,
                        Stored = true
                    })
                    .WithSettings(new ElasticContentIndexSettings
                    {
                        Included = true
                    })));

            return 2;
        }
    }
}
