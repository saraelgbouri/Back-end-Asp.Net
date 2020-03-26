using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiItNews.Data;
using WebApiItNews.Models;

namespace WebApiItNews.Controllers
{
    public class JournalistController : ApiController
    {
        public IHttpActionResult GetJournalist(int id = 0)
        {

            JournalistViewModel vm;
            using (var context = new ItNewsEntities())
            {
                var j = context.Journalistes.Where(jl => jl.ID == id).FirstOrDefault();
                vm = new JournalistViewModel();
                vm.ID = id;
                vm.Nom = j.Nom;
                vm.Prenom = j.Prenom;
                var al = new List<ArticleModel>();
                foreach (var a in j.Article)
                {
                    ArticleModel am = new ArticleModel();
                    am.ID = a.ID;
                    am.Titre = a.Titre;
                    am.Body = a.Body;
                    am.Img = a.Img;
                    am.Date = a.Date.ToString();
                    am.Video = a.video;

                    al.Add(am);
                }
                vm.articles = al;

            }
            return Ok(vm);
        }
    }
}
