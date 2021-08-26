using Microsoft.AspNetCore.Mvc;
using BlueMusicAPI.Models;
using BlueMusicAPI.Services;
using System;
using Microsoft.AspNetCore.Authorization;

namespace BlueMusicAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ApiBaseController
    {
        IMusicService _service;
        //IMusicService _staticService;

        public MusicController(IMusicService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());

        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
            ApiNotFound("Música não encontrada.") :
            ApiOk(_service.Get(id));


        [Route("random")]
        [HttpGet]
        public IActionResult Random() 
        {
            var lista = _service.All();
            Random rand = new();          
            return ApiOk(lista[rand.Next(lista.Count)]);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create([FromBody] Music music)
        {
            var user = User.Identity.Name;
            music.CreatedBy = user;
            return _service.Create(music) ? ApiOk("Música inserida com sucesso.") : ApiNotFound("Erro ao inserir música.");
        }

        [Authorize]
        [HttpPut]
        public IActionResult Update([FromBody] Music music)
        {
            var user = User.Identity.Name;
            music.UpdatedBy = user;
            return _service.Update(music) ? ApiOk("Música atualizada com sucesso.") : ApiNotFound("Erro ao atualizar música.");
        }

        [Authorize]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Música excluída com sucesso.") :
            ApiNotFound("Erro ao excluir música.");
    }
}
