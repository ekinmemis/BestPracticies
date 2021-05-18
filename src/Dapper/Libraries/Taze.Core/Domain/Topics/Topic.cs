using System;

namespace Taze.Core.Domain.Topics
{
    /// <summary>
    /// Represents a topic.
    /// </summary>
    public partial class Topic : BaseEntity
    {
        /// <summary>
        /// Gets or sets the SystemName.
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is published.
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the CreatedOnUtc
        /// Gets or sets created date time utc.
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedOnUtc
        /// Gets or sets updated date time utc.
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the TopicTypeId.
        /// </summary>
        public int TopicTypeId { get; set; }

        /// <summary>
        /// Gets or sets the TopicType.
        /// </summary>
        public TopicType TopicType { get => (TopicType)TopicTypeId; set => TopicTypeId = (int)value; }

        #endregion
    }
}
