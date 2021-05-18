namespace Taze.Web.Api.Model.Topics
{
    public class TopicModel
    {
        public string SystemName { get; set; }

        public int DisplayOrder { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public bool Published { get; set; }

        public int TopicTypeId { get; set; }
    }
}
