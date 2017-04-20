using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GrabBag.Models;

namespace GrabBag.DAL
{
    public class GrabBagInitializer : DropCreateDatabaseIfModelChanges<GrabBagContext>
    {
        protected override void Seed(GrabBagContext context)
        {
            var Photos = new List<Photo>()
        {
            new Photo{UserId=2,File=null, Latitude="12 20 00", Longitude="20 30 00", Date=null,IsActive=true },
            new Photo{UserId=3,File=null, Latitude="12 20 00", Longitude="20 30 00", Date=null,IsActive=true },
            new Photo{UserId=2,File=null, Latitude="12 20 00", Longitude="20 30 00", Date=null,IsActive=true },
            new Photo{UserId=3,File=null, Latitude="12 20 00", Longitude="20 30 00", Date=null,IsActive=true },
            new Photo{UserId=2,File=null, Latitude="12 20 00", Longitude="20 30 00", Date=null,IsActive=true }
        };
            Photos.ForEach(s => context.Photos.Add(s));
            context.SaveChangesAsync();

            var Users = new List<User>()
            {
                new User{Username="Lame", Password="pass", Token="assssssss", IsActive=true},
                new User{Username="Na", Password="pass", Token="assssssss", IsActive=true},
                new User{Username="As", Password="pass", Token="assssssss", IsActive=true},
                new User{Username="Kr", Password="pass", Token="assssssss", IsActive=true}
                
            };
            Users.ForEach(x => context.Users.Add(x));
            context.SaveChangesAsync();

            var Bookmark = new List<Bookmark>()
            {
                new Bookmark{UserId=2, Url="https://gay.com", IsActive=true},
                new Bookmark{UserId=2, Url="https://gay.com", IsActive=true},
                new Bookmark{UserId=2, Url="https://gay.com", IsActive=true},
                new Bookmark{UserId=2, Url="https://gay.com", IsActive=true}
            };
            Bookmark.ForEach(z => context.Bookmarks.Add(z));
            context.SaveChangesAsync();


        }
        
    }
}