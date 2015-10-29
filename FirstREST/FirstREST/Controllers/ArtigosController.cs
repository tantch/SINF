using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;


namespace FirstREST.Controllers
{
    public class ArtigosController : ApiController
    {
        //
        // GET: /Artigos/

        public IEnumerable<Lib_Primavera.Model.Artigo> Get()
        {
            return Lib_Primavera.PriIntegration.ListaArtigos();
        }



        // GET api/artigo/5    
        public Artigo Get(string id)
        {
            Lib_Primavera.Model.Artigo artigo = Lib_Primavera.PriIntegration.GetArtigo(id);
            if (artigo == null)
            {
                throw new HttpResponseException(
                  Request.CreateResponse(HttpStatusCode.NotFound));
            }
            else
            {
                return artigo;
            }
        }
        [Route("api/artigos/nome/{nome}")]
        public Artigo GetBook(String nome)
        {
            Lib_Primavera.Model.Artigo artigo = Lib_Primavera.PriIntegration.GetArtigoNome(nome);
            if (artigo == null)
            {
                throw new HttpResponseException(
                  Request.CreateResponse(HttpStatusCode.NotFound));
            }
            else
            {
                return artigo;
            }
        }
        [Route("api/artigos/pesquisaNome/{nome}/{num}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> Get(String nome, int num)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosNome(nome, num);
        }
        [Route("api/artigos/listaRecentes/{lim}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> Get(int lim)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosRecentes(lim);
        }

        [Route("api/artigos/cat/{cat}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> GetCat(string cat)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosCategoria(cat);
        }
    }
}

