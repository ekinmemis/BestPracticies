using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Taze.Core.Domain.Topics;
using Taze.Services.Topics;
using Taze.Web.Api.Model.Topics;

namespace Taze.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;
        private readonly IMapper _mapper;

        public TopicController(ITopicService topicService, IMapper mapper)
        {
            _topicService = topicService;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Topic> Get()
        {
            return _topicService.GetAllTopics();
        }

        [HttpGet("{id}")]
        public Topic Get(int id)
        {
            return _topicService.GetTopicById(id);
        }

        [HttpPost]
        public void Post([FromBody] TopicModel model)
        {
            var topic = _mapper.Map<Topic>(model);

            _topicService.InsertTopic(topic);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TopicModel model)
        {
            var entity = _topicService.GetTopicById(id);

            //entity = _mapper.Map<Topic>(model);

            entity.SystemName = model.SystemName;
            entity.DisplayOrder = model.DisplayOrder;
            entity.Title = model.Title;
            entity.Body = model.Body;
            entity.Published = model.Published;
            entity.TopicTypeId = model.TopicTypeId;
            entity.UpdatedOnUtc = DateTime.Now;

            _topicService.UpdateTopic(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _topicService.DeleteTopicById(id);
        }
    }
}
