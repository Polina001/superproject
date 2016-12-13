namespace Logic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Logic.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Logic.Context";
        }

        protected override void Seed(Logic.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            // Load file meta data with FileInfo
            FileInfo fileInfo = new FileInfo(@"2.jpg");

            // The byte[] to save the data in
            byte[] img = new byte[fileInfo.Length];

            // Load a filestream and put its content into the byte[]
            using (FileStream fs = fileInfo.OpenRead())
            {
                fs.Read(img, 0, img.Length);
            }

            var curTheme = new Theme
            {
                ThemeName = "Christmas",

            };
            context.Theme.AddOrUpdate(a => a.ThemeName, curTheme);
            context.Pictures.Add(new PictureForProject
            {
                PictureCard = img,
                ThemeID = curTheme.ID
            });
            
            context.SaveChanges();
            
        }
    }
}
