using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Taze.Core.Domain.Topics;

namespace Taze.Data
{
    /// <summary>
    /// Defines the <see cref="TopicRepository" />.
    /// </summary>
    public class TopicRepository : ITopicRepository
    {
        /// <summary>
        /// The GetTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Topic"/>.</returns>
        public Topic GetTopicById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("id");

            var sql = "SELECT * FROM Topic WHERE Id = @Id";
            using var connection = new SqlConnection(DbExtensions.ConnectionString);
            connection.Open();
            var result = connection.QuerySingleOrDefault<Topic>(sql, new { Id = id });
            connection.Close();

            return result;
        }

        /// <summary>
        /// The GetAllTopics.
        /// </summary>
        /// <returns>The <see cref="List{Topic}"/>.</returns>
        public List<Topic> GetAllTopics()
        {
            var sql = "SELECT * FROM Topic";
            using var connection = new SqlConnection(DbExtensions.ConnectionString);
            connection.Open();
            var result = connection.Query<Topic>(sql);
            connection.Close();
            return result.ToList();
        }

        /// <summary>
        /// The InsertTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        public void InsertTopic(Topic topic)
        {
            topic.CreatedOnUtc = DateTime.UtcNow;
            topic.UpdatedOnUtc = DateTime.UtcNow;
            var sql = "Insert into Topic (SystemName,DisplayOrder,Title,Body,Published,CreatedOnUtc,UpdatedOnUtc,TopicTypeId) VALUES (@SystemName,@DisplayOrder,@Title,@Body,@Published,@CreatedOnUtc,@UpdatedOnUtc,@TopicTypeId)";
            using var connection = new SqlConnection(DbExtensions.ConnectionString);
            connection.Open();
            connection.Execute(sql, topic);
            connection.Close();
        }

        /// <summary>
        /// The UpdateTopic.
        /// </summary>
        /// <param name="topic">The topic<see cref="Topic"/>.</param>
        public void UpdateTopic(Topic topic)
        {
            if (topic == null)
                throw new ArgumentNullException("topic");

            topic.UpdatedOnUtc = DateTime.Now;
            var sql = "UPDATE Topic SET SystemName = @SystemName, DisplayOrder = @DisplayOrder, Title = @Title, Body = @Body, Published = @Published, UpdatedOnUtc = @UpdatedOnUtc, TopicTypeId = @TopicTypeId  WHERE Id = @Id";
            using var connection = new SqlConnection(DbExtensions.ConnectionString);
            connection.Open();
            connection.Execute(sql, topic);
            connection.Close();
        }

        /// <summary>
        /// The DeleteTopicById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        public void DeleteTopicById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("id");

            var sql = "DELETE FROM Topic WHERE Id = @Id";

            using var connection = new SqlConnection(DbExtensions.ConnectionString);
            connection.Open();
            connection.Execute(sql, new { Id = id });
            connection.Close();
        }
    }
}
