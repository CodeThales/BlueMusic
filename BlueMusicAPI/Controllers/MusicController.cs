﻿using Microsoft.AspNetCore.Mvc;
using BlueMusicAPI.Models;
using BlueMusicAPI.Services;

namespace BlueMusicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ApiBaseController
    {
        IMusicService _service;

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


        [HttpPost]
        public IActionResult Create([FromBody] Music music) =>
            _service.Create(music) ?
            ApiOk("Música inserida com sucesso.") :
            ApiNotFound("Erro ao inserir música.");


        [HttpPut]
        public IActionResult Update([FromBody] Music music) =>
            _service.Update(music) ?
            ApiOk("Música atualizada com sucesso.") :
            ApiNotFound("Erro ao atualizar música.");


        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
            ApiOk("Música excluída com sucesso.") :
            ApiNotFound("Erro ao excluir música.");
    }
}