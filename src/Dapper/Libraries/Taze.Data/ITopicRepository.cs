using System.Collections.Generic;
using Taze.Core.Domain.Topics;

namespace Taze.Data
{
    /// <summary>
    /// Defines the <see cref="ITopicRepository" />.
    /// </summary>
    public interface ITopicRepository
    {
        /// <summary>
        /// The GetTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Topic"/>.</returns>
        Topic GetTopicById(int id);

        /// <summary>
        /// The GetAllTopics.
        /// </summary>
        /// <returns>The <see cref="List{Topic}"/>.</returns>
        List<Topic> GetAllTopics();

        /// <summary>
        /// The InsertTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        void InsertTopic(Topic topic);

        /// <summary>
        /// The UpdateTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        void UpdateTopic(Topic topic);

        /// <summary>
        /// The DeleteTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        void DeleteTopicById(int id);
    }
}
