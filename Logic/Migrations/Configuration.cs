namespace Logic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Text;
    internal sealed class Configuration : DbMigrationsConfiguration<Logic.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Logic.Context";
        }

        protected override void Seed(Logic.Context context)
        {

            var curTheme = new Theme
            {
                ThemeName = "Christmas",

            };
            context.Theme.AddOrUpdate(a => a.ThemeName, curTheme);
            //Load file meta data with FileInfo
            FileInfo fileInfo1 = new FileInfo(@"нг1.jpg");
            FileInfo fileInfo2 = new FileInfo(@"нг2.jpg");
            FileInfo fileInfo3 = new FileInfo(@"нг3.jpg");
            FileInfo fileInfo4 = new FileInfo(@"нг4.jpg");
            FileInfo fileInfo5 = new FileInfo(@"нг5.jpg");
            // The byte[] to save the data in
            byte[] img1 = new byte[fileInfo1.Length];
            byte[] img2 = new byte[fileInfo2.Length];
            byte[] img3 = new byte[fileInfo3.Length];
            byte[] img4 = new byte[fileInfo4.Length];
            byte[] img5 = new byte[fileInfo5.Length];
            // Load a filestream and put its content into the byte[]

            using (FileStream fs = fileInfo1.OpenRead())
            {
                fs.Read(img1, 0, img1.Length);
            }
            var curImage1 = new PictureForProject
            {
                PictureCard = img1,
                ThemeID = curTheme.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage1);
            using (FileStream fs = fileInfo2.OpenRead())
            {
                fs.Read(img2, 0, img2.Length);
            }
            var curImage2 = new PictureForProject
            {
                PictureCard = img2,
                ThemeID = curTheme.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage2);
            using (FileStream fs = fileInfo3.OpenRead())
            {
                fs.Read(img3, 0, img3.Length);
            }
            var curImage3 = new PictureForProject
            {
                PictureCard = img3,
                ThemeID = curTheme.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage3);
            using (FileStream fs = fileInfo4.OpenRead())
            {
                fs.Read(img4, 0, img4.Length);
            }
            var curImage4 = new PictureForProject
            {
                PictureCard = img4,
                ThemeID = curTheme.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage4);
            using (FileStream fs = fileInfo5.OpenRead())
            {
                fs.Read(img5, 0, img5.Length);
            }
            var curImage5 = new PictureForProject
            {
                PictureCard = img5,
                ThemeID = curTheme.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage5);
            context.SaveChanges();
            var curTheme2 = new Theme
            {
                ThemeName = "Birthday",
            };
            context.Theme.AddOrUpdate(a => a.ThemeName, curTheme2);
            //Load file meta data with FileInfo
            FileInfo fileInfo6 = new FileInfo(@"др1.jpg");
            FileInfo fileInfo7 = new FileInfo(@"др2.jpg");
            FileInfo fileInfo8 = new FileInfo(@"др3.jpg");
            FileInfo fileInfo9 = new FileInfo(@"др4.jpg");
            FileInfo fileInfo0 = new FileInfo(@"др5.jpg");
            // The byte[] to save the data in
            byte[] img6 = new byte[fileInfo6.Length];
            byte[] img7 = new byte[fileInfo7.Length];
            byte[] img8 = new byte[fileInfo8.Length];
            byte[] img9 = new byte[fileInfo9.Length];
            byte[] img0 = new byte[fileInfo0.Length];
            // Load a filestream and put its content into the byte[]

            using (FileStream fs = fileInfo6.OpenRead())
            {
                fs.Read(img6, 0, img6.Length);
            }
            var curImage6 = new PictureForProject
            {
                PictureCard = img6,
                ThemeID = curTheme2.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage6);
            using (FileStream fs = fileInfo7.OpenRead())
            {
                fs.Read(img7, 0, img7.Length);
            }
            var curImage7 = new PictureForProject
            {
                PictureCard = img7,
                ThemeID = curTheme2.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage7);
            using (FileStream fs = fileInfo8.OpenRead())
            {
                fs.Read(img8, 0, img8.Length);
            }
            var curImage8 = new PictureForProject
            {
                PictureCard = img8,
                ThemeID = curTheme2.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage8);
            using (FileStream fs = fileInfo9.OpenRead())
            {
                fs.Read(img9, 0, img9.Length);
            }
            var curImage9 = new PictureForProject
            {
                PictureCard = img9,
                ThemeID = curTheme2.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage9);
            using (FileStream fs = fileInfo0.OpenRead())
            {
                fs.Read(img0, 0, img0.Length);
            }
            var curImage0 = new PictureForProject
            {
                PictureCard = img0,
                ThemeID = curTheme2.ID
            };
            context.Pictures.AddOrUpdate(a => a.PictureCard, curImage0);

            context.SaveChanges();

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
            //FileInfo fileInfo = new FileInfo(@"нг5.jpg");

            //// The byte[] to save the data in
            //byte[] img = new byte[fileInfo.Length];

            //// Load a filestream and put its content into the byte[]
            //using (FileStream fs = fileInfo.OpenRead())
            //{
            //    fs.Read(img, 0, img.Length);
            //}

            //string[] mas = File.ReadAllLines(@"govno.txt");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    var data = mas[i].Split(';');
            //    var curTheme = new Theme
            //    {
            //        ThemeName = data[1],

            //    };
            //    context.Theme.AddOrUpdate(a => a.ThemeName, curTheme);


            //    var curImage = new PictureForProject
            //    {
            //        PictureCard = Encoding.ASCII.GetBytes(data[0]),
            //        ThemeID = curTheme.ID
            //    };

            //    context.Pictures.AddOrUpdate(a => a.PictureCard, curImage);

            //    context.SaveChanges();
            //}

        }
    }
}
