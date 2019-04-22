using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteCongChung.Models;
using ServiceStack.OrmLite;
namespace WebsiteCongChung.DAL
{
    public static class HopDongDAL
    {
        public static IList<HopDongViewModel> Any()
        {
            var dbFactory = new OrmLiteConnectionFactory(Constants.ConnectionString, SqlServerDialect.Provider);
            using (var db = dbFactory.Open())
            {
                var hd = db.Select<HopDongViewModel>();
                return hd;
            }
        }

        public static bool Create()
        {
            return false;
        }
    }
}