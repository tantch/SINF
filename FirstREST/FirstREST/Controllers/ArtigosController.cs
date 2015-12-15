using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;
using System.Web.Http.Cors;

namespace FirstREST.Controllers
{
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    public class ArtigosController : ApiController
    {
        /// <summary>
        /// Get que retorna lista de todos os livros
        /// </summary>
        public IEnumerable<Lib_Primavera.Model.Artigo> Get()
        {
            return Lib_Primavera.PriIntegration.ListaArtigos();
        }



        /// <summary>
        /// Get para ir buscar informação de um livro
        /// </summary>
        /// <param name="id"> id do livro</param>
        /// <returns>objecto com informacoes do livro</returns>
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
        /// <summary>
        /// Get para pesquisar um livro por nome , pesquisa "sinto-me com sorte"
        /// </summary>
        /// <param name="nome">query para pesquisa</param>
        /// <returns>objecto com informacoes do livro</returns>
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

        /// <summary>
        /// Get para pesquisar livros por query
        /// </summary>
        /// <param name="nome">query de pesquisa</param>
        /// <param name="num">limite de resultados a devolver</param>
        /// <returns>Lista de livros com as respectivas informacoes</returns>
        [Route("api/artigos/pesquisaNome/{nome}/{num}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> Get(String nome, int num)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosNome(nome, num);
        }
        /// <summary>
        /// Get para ver os livros mais recentes
        /// </summary>
        /// <param name="lim">limite de resulados a receber</param>
        /// <returns>Lista de livros com as respectivas informacoes e ordenados do mais recente pro mais antigo</returns>
        [Route("api/artigos/listaRecentes/{lim}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> Get(int lim)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosRecentes(lim);
        }

        /// <summary>
        /// Get para ver os livros duma categoria
        /// </summary>
        /// <param name="cat">categoria dos livros</param>
        /// <returns>lista de lviros com as respectivas informacoes</returns>
        [Route("api/artigos/cat/{cat}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> GetCat(string cat)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosCategoria(cat);
        }
        /// <summary>
        /// Get para ver os livros de um autor
        /// </summary>
        /// <param name="aut">Autor dos livros</param>
        /// <returns>lista de livros com as respectivas informacoes</returns>
        [Route("api/artigos/autor/{aut}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> GetAut(string aut)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosAutor(aut);
        }
        /// <summary>
        /// Get para ver os livros com melhor rating
        /// </summary>
        /// <param name="lim">limite de resultados a mostrar</param>
        /// <returns>lista de livros com as respectivas informacoes</returns>
        [Route("api/artigos/listaRating/{lim}")]
        public IEnumerable<Lib_Primavera.Model.Artigo> GetRat(int lim)
        {
            return Lib_Primavera.PriIntegration.ListaArtigosMelhores(lim);
        }
    }
}

