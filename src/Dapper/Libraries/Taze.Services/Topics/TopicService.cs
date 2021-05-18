using System.Collections.Generic;
using Taze.Core.Domain.Topics;
using Taze.Data;

namespace Taze.Services.Topics
{
    /// <summary>
    /// Defines the <see cref="TopicService" />.
    /// </summary>
    public class TopicService : ITopicService
    {
        /// <summary>
        /// Defines the _topicRepository.
        /// </summary>
        private readonly ITopicRepository _topicRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicService"/> class.
        /// </summary>
        /// <param name="topicRepository">The topicRepository<see cref="ITopicRepository"/>.</param>
        public TopicService(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        /// <summary>
        /// The GetTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Topic"/>.</returns>
        public Topic GetTopicById(int id)
        {
            return _topicRepository.GetTopicById(id);
        }

        /// <summary>
        /// The GetAllTopics.
        /// </summary>
        /// <returns>The <see cref="List{Topic}"/>.</returns>
        public List<Topic> GetAllTopics()
        {
            return _topicRepository.GetAllTopics();
        }

        /// <summary>
        /// The InsertTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        public void InsertTopic(Topic topic)
        {
            _topicRepository.InsertTopic(topic);
        }

        /// <summary>
        /// The UpdateTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        public void UpdateTopic(Topic topic)
        {
            _topicRepository.UpdateTopic(topic);
        }

        /// <summary>
        /// The DeleteTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        public void DeleteTopicById(int id)
        {
            _topicRepository.DeleteTopicById(id);
        }
    }
}
