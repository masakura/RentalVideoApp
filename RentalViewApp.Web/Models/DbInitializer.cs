using System.Data.Entity;

namespace RentalViewApp.Web.Models
{
    internal sealed class DbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);

            context.Videos.AddRange(new[]
            {
                Video("スターウォーズ エピソード 7", VideoType.New),
                Video("スターウォーズ エピソード 6", VideoType.Old),
                Video("スターウォーズ エピソード 5", VideoType.Old),
                Video("スターウォーズ エピソード 4", VideoType.Old),
                Video("スターウォーズ エピソード 3", VideoType.Normal),
                Video("スターウォーズ エピソード 2", VideoType.Normal),
                Video("スターウォーズ エピソード 1", VideoType.Normal),
                Video("ドラえもん のび太の宇宙開拓", VideoType.Kids)
            });
        }

        private static Video Video(string title, VideoType type)
        {
            return new Video {Title = title, Type = type};
        }
    }
}